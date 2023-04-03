using Campus.Application.AppSettings;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.Domain;
using Campus.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Campus.Application.Services;
public class TokenService : ITokenService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IDistributedCache _cache;
    private readonly ILogger<TokenService> _logger;
    private readonly JwtSettings _jwtSettings;

    private const string RefreshTokenPrefix = "REFRESH_TOKEN_";
    private const string Key = "SECRETKEY";
    private readonly TimeSpan RefreshTokenExpiration = TimeSpan.FromDays(7);

    public TokenService(
        UserManager<User> userManager,
        SignInManager<User> signInManager,
        IOptions<JwtSettings> jwtSettings,
        IDistributedCache cache,
        ILogger<TokenService> logger)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _cache = cache;
        _logger = logger;
        _jwtSettings = jwtSettings.Value;
    }

    public async Task<Token> GenerateTokenAsync(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);

        var token = GenerateToken(user, _jwtSettings.Issuer, _jwtSettings.Audience, _jwtSettings.ExpirationInMinutes);

        var refreshToken = GenerateRefreshToken();

        await _cache.SetStringAsync(RefreshTokenPrefix + refreshToken, user.Id, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = RefreshTokenExpiration
        });

        return new Token
        {
            AccessToken = token,
            RefreshToken = refreshToken
        };
    }

    public async Task<Token> RefreshTokenAsync(string token, string refreshToken)
    {
        var userId = await _cache.GetStringAsync(RefreshTokenPrefix + refreshToken);
        var user = await _userManager.FindByIdAsync(userId);

        if (userId == null || user == null)
        {
            throw new InvalidTokenException($"{nameof(RefreshTokenAsync)}: The provided refresh token is invalid or has expired.");
        }

        var isValid = await ValidateTokenAsync(user, token);
        if (!isValid)
        {
            throw new InvalidTokenException($"{nameof(RefreshTokenAsync)}The refresh token provided is invalid");
        }

        var newToken = GenerateToken(user, _jwtSettings.Issuer, _jwtSettings.Audience, _jwtSettings.ExpirationInMinutes);

        var newRefreshToken = GenerateRefreshToken();

        await _cache.SetStringAsync(RefreshTokenPrefix + newRefreshToken, user.Id, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = RefreshTokenExpiration
        });

        await _cache.RemoveAsync(RefreshTokenPrefix + refreshToken);

        return new Token
        {
            AccessToken = newToken,
            RefreshToken = newRefreshToken
        };
    }

    public async Task<bool> ValidateTokenAsync(User user, string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var secretKey = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable(Key));
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                ValidateIssuer = true,
                ValidIssuer = _jwtSettings.Issuer,
                ValidateAudience = true,
                ValidAudience = _jwtSettings.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = jwtToken.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId != user.Id)
            {
                _logger.LogError($"{nameof(ValidateTokenAsync)} Invalid refresh token.");
                return false;
            }

            return true;
        }
        catch(Exception ex) 
        {
            _logger.LogError(ex.Message, ex);
            return false;
        }
    }

    private string GenerateToken(User user, string issuer, string audience, int expiration)
    {
        var password = "DMMYTRENKO";
        var iterations = 10000;

        var salt = new byte[16];
        using (var generator = new RNGCryptoServiceProvider())
        {
            generator.GetBytes(salt);
        }

        var key = new Rfc2898DeriveBytes(password, salt, iterations).GetBytes(32);

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var signingKey = new SymmetricSecurityKey(key);
        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiration),
            signingCredentials: signingCredentials);

        var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);

        return encodedToken;
    }

    private string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);

        return Convert.ToBase64String(randomNumber);
    }
}
