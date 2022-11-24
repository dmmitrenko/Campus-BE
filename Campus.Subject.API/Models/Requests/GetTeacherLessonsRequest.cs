namespace Campus_Subject.API.Models.Requests;

public record GetTeacherLessonsRequest
{
    public Guid TeacherId { get; init; }
}
