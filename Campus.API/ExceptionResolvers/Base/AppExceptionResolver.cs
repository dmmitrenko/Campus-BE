using Campus.API.Models.ErrorResponses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.ExceptionResolvers.Base;

public class AppExceptionResolver : IExceptionResolver
{
    private readonly ILogger _logger;

    public AppExceptionResolver(ILogger<AppExceptionResolver> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        var id = Guid.NewGuid();
        var errorResponse = new ErrorModel
        {
            StatusCode = StatusCodes.Status409Conflict,
            Message = $"Unexpected result, please contact to the support. Ticket id : {id}"
        };

        _logger.LogError(context.Exception, $"ErrorId : {id}");
        context.HttpContext.Response.StatusCode = StatusCodes.Status409Conflict;
        context.Result = new ObjectResult(errorResponse);
    }
}
