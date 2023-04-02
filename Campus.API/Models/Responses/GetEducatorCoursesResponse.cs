using Campus.Domain.Models;

namespace Campus.API.Models.Responses;

public record GetEducatorCoursesResponse
{
    public IEnumerable<Course> Courses { get; set; }
}
