using Campus.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Campus.Core.Interfaces;
public interface IUserService
{
    Task<IdentityResult> RegisterUser(User user);
    Task<bool> ValidateUser(string userName, string password);
}
