using Campus.Domain.Exceptions;
using Campus.API.ExceptionResolvers.Base;
using Campus.API.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.ExceptionResolvers;

public class AppExceptionResolver : IExceptionResolver<CampusException>
{
    private readonly ILogger _logger;

    public AppExceptionResolver(ILogger<AppExceptionResolver> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        var id = Guid.NewGuid();
        var errorResponse = new ErrorDetails
        {
            StatusCode = StatusCodes.Status409Conflict,
            Message = $"Unexpected result, please contact to the support. Ticket id : {id}"
        };

        _logger.LogError(context.Exception, $"ErrorId : {id}");
        context.HttpContext.Response.StatusCode = StatusCodes.Status409Conflict;
        context.Result = new ObjectResult(errorResponse);
    }
}
