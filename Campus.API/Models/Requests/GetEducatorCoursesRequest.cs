namespace Campus.API.Models.Requests;

public class GetEducatorCoursesRequest : BaseRequest
{
    public const string Route = "v1/courses";
    public Guid EducatorId { get; set; }
}
