namespace Campus.API.Models.Requests;

public record AddTeacherRequest
{
    public string FirstName { get; init; }
    public string MiddleName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
}
