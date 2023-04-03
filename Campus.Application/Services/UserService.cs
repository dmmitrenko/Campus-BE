using AutoMapper;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Campus.Application.Services;
public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;
    private readonly ILogger<UserService> _logger;
    private readonly IMapper _mapper;

    public UserService(
        UserManager<User> userManager,
        ILogger<UserService> logger,
        IMapper mapper)
    {
        _userManager = userManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IdentityResult> RegisterUser(Domain.Models.User user)
    {
        var identityUser = _mapper.Map<User>(user);

        var result = await _userManager.CreateAsync(identityUser, user.Password);
        if (result.Succeeded)
        {
            await _userManager.AddToRolesAsync(identityUser, user.Roles.Select(x => x.ToString()));
        }

        return result;
    }

    public async Task<bool> ValidateUser(string userName, string password)
    {
        var user = await _userManager.FindByNameAsync(userName);

        var isSuccess = (user != null && await _userManager.CheckPasswordAsync(user, password));
        if (!isSuccess)
        {
            _logger.LogWarning($"{nameof(ValidateUser)}: Authentication failed. Wrong user name or password.");
        }

        return isSuccess;
    }
}
