namespace Campus.API.Models.Requests;

public class GetEducatorByCodeRequest
{
    public const string Route = "v1/educator";

    public string EducatorCode { get; set; }

    public string GetRouteTemplate() => Route;
}
