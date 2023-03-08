namespace Campus.Domain.ErrorModels;
public class ApiError
{
    public string Message { get; private set; }

    public int? InternalErrorCode { get; private set; }

    public IList<ApiErrorDetails> ErrorDetails { get; private set; }

    public ApiError(string message, int? internalErrorCode, IList<ApiErrorDetails> errorDetails)
    {
        Message = message;
        InternalErrorCode = internalErrorCode;
        ErrorDetails = errorDetails;
    }
}
