namespace Campus.Domain.ErrorModels;
public class ApiErrorBase
{
    public ApiError Error { get; private set; }

    public IDictionary<string, string> AdditionalInfo { get; private set; }

    public ApiErrorBase(ApiError error, IDictionary<string, string> additionalInfo)
    {
        Error = error;
        AdditionalInfo = additionalInfo;
    }
}
