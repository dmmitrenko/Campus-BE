namespace Campus.API.Models.Requests;

public class AddEducatorRequest
{
    public const string Route = "v1/educator";

    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
