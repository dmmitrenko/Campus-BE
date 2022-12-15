namespace Campus.API.Models.Requests;

public record AddClassroomRequest
{
    public string Title { get; init; }
    public int Grade { get; init; }
    public DateOnly SemesterStartDate { get; init; }
}
