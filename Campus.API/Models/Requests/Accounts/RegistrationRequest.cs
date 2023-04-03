using Campus.Domain.Enums;

namespace Campus.API.Models.Requests.Accounts;

public record RegistrationRequest
{
    public const string Route = "v1";
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Username { get; init; }
    public string Password { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public ICollection<Roles> Roles { get; init; }
}
