using Campus.API.ExceptionResolvers.Base;
using Campus.API.Models.ErrorResponses;
using Campus.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.ExceptionResolvers;

public class SubjectNotFoundExceptionResolver : IExceptionResolver<SubjectNotFoundException>
{
    private readonly ILogger _logger;

    public SubjectNotFoundExceptionResolver(ILogger<SubjectNotFoundException> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        var errorResponse = new ErrorModel
        {
            StatusCode = StatusCodes.Status404NotFound,
            Message = context.Exception.Message
        };

        _logger.LogInformation(context.Exception.Message);
        context.HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
        context.Result = new ObjectResult(errorResponse);
    }
}
