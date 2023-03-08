using Campus.API.ExceptionHandler;
using Campus.Domain.ErrorModels;
using Newtonsoft.Json;

namespace Campus.API.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);

        }
        catch (Exception ex)
        {

            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
    {
        httpContext.Response.ContentType = "application/json";
        var responseDetails = ex.GetInfo();
        LogException(responseDetails, ex);
        httpContext.Response.StatusCode = (int)responseDetails.StatusCode;

        var errors = new List<ApiErrorDetails>();

        if (responseDetails.Errors != null)
        {
            foreach (var error in responseDetails.Errors)
            {
                errors.Add(new ApiErrorDetails { Message = error.Message });
            }
        }

        ApiErrorBase errorDetails = new ApiErrorBase(
            new ApiError(responseDetails.Message, (int)responseDetails.StatusCode, errors),
            responseDetails.AdditionalInfo);

        return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(errorDetails));
    }

    private void LogException(ResponseDetails responseDetails, Exception exception)
    {
        var listErrors = new List<string>();

        if (responseDetails.Errors != null)
        {
            foreach (var error in responseDetails.Errors)
            {
                listErrors.Add(error.Message);
            }
        }

        var response = new
        {
            Errors = listErrors,
            Message = responseDetails.Message,
            InternalErrorCode = (int)responseDetails.StatusCode,
            StatusCode = responseDetails.StatusCode.ToString(),
        };

        var dict = new Dictionary<string, object>
        {
            { "AdditionalInfo", response },
        };

        _logger.Log(responseDetails.LogLevel, default, dict, exception, (o, ex) => responseDetails.Message);
    }
}
