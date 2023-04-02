namespace Campus.API.Models.Requests;

public abstract class BaseRequest
{
    public override string GetRouteTemplate() => Route;
}
