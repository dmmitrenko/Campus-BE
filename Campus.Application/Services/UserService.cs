using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Campus.Application.Services;
public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;
    private readonly ILogger<UserService> _logger;

    public UserService(
        UserManager<User> userManager,
        ILogger<UserService> logger)
    {
        _userManager = userManager;
        _logger = logger;
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
