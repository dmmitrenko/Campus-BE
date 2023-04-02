namespace Campus.API.Models.Responses;

public record TokenResponse
{
    public string Token { get; init; }
    public string RefreshToken { get; set; }
}
