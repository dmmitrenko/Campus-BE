namespace Campus.API.Models.Requests;

public record AddCourseForEducatorRequest
{
    public Guid TeacherId { get; init; }
    public Guid LessonId { get; init; }
}
