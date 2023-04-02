using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.API.Models.Requests.Accounts;
using Campus.API.Models.Responses;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.Domain.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers;

public class AuthenticationController : BaseController<AuthenticationController>
{
    private readonly IUserService _userService;
    private readonly ITokenService _tokenService;

    public AuthenticationController(
        IMapper mapper, 
        ILogger<AuthenticationController> logger,
        IUserService userService,
        ITokenService tokenService) 
        : base(mapper, logger)
    {
        _userService = userService;
        _tokenService = tokenService;
    }

    [HttpPost(AuthenticationRequest.Route)]
    [ProducesResponseType(typeof(TokenResponse), 200)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<TokenResponse> Authenticate([FromBody]AuthenticationRequest request)
    {
        if(!await _userService.ValidateUser(request.Username, request.Password))
        {
            throw new InvalidCredentialsException("Invalid username or password.");
        }

        var token = await _tokenService.GenerateTokenAsync(request.Username);

        return new TokenResponse
        {
            Token = token.AccessToken,
            RefreshToken = token.RefreshToken,
        };
    }
}
