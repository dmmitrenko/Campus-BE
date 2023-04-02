namespace Campus.API.Models.Requests.Accounts;

public record AuthenticationRequest
{
    public const string Route = "v1/login";
    public string Username { get; init; }
    public string Password { get; set; }
}
