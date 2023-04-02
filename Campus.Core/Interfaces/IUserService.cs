namespace Campus.Core.Interfaces;
public interface IUserService
{
    Task<bool> ValidateUser(string userName, string password);
}
