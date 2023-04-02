using Campus.DataContext.Entities;
using Campus.Domain;

namespace Campus.Core.Interfaces;
public interface ITokenService
{
    Task<Token> GenerateTokenAsync(string userName);
    Task<Token> RefreshTokenAsync(string token, string refreshToken);
    Task<bool> ValidateTokenAsync(User user, string token);
}
