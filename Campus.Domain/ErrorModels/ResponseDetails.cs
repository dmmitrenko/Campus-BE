using Microsoft.Extensions.Logging;
using System.Net;

namespace Campus.Domain.ErrorModels;
public class ResponseDetails
{
    public ResponseDetails(
        HttpStatusCode statusCode,
        string message,
        LogLevel logLevel = LogLevel.Error,
        IDictionary<string, string>? additionalInfo = null,
        IList<ResponseInfo>? errors = null)
    {
        StatusCode = statusCode;
        Message = message;
        LogLevel = logLevel;
        AdditionalInfo = additionalInfo ?? new Dictionary<string, string>();
        Errors = errors ?? new List<ResponseInfo>();
    }

    public string Message { get; set; }

    public IList<ResponseInfo> Errors { get; }

    public IDictionary<string, string> AdditionalInfo { get; }

    public HttpStatusCode StatusCode { get; }

    public LogLevel LogLevel { get; }
}
