namespace Campus.Domain;
public record Token
{
    public string AccessToken { get; init; }
    public string RefreshToken { get; init; }
}
