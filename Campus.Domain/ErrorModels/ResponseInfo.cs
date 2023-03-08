namespace Campus.Domain.ErrorModels;
public class ResponseInfo
{
    public ResponseInfo(string message)
    {
        Message = message;
    }

    public string Message { get; }
}
