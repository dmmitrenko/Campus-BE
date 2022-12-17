namespace Campus.API.Models.Requests;

public record AddClassroomRequest
{
    public string Title { get; init; }
    public int Grade { get; init; }
    public DateOnly SemesterStartDate { get; init; }
    public DateOnly SemesterEndDate { get; set; }
    public int SemestrNumber { get; set; }
}
