using Campus.Domain.ErrorModels;
using Campus.Domain.Exceptions;
using System.Net;

namespace Campus.API.ExceptionHandler;

public static class ExceptionMapper
{
    private static readonly Dictionary<Type, Func<Exception, ResponseDetails>> StatusesMapper;
    static ExceptionMapper()
    {
        StatusesMapper = new Dictionary<Type, Func<Exception, ResponseDetails>>
        {
            [typeof(NotFoundException)] = (e) => new ResponseDetails(HttpStatusCode.BadRequest, e.Message, LogLevel.Warning),
            [typeof(ValidationException)] = (e) => new ResponseDetails(HttpStatusCode.BadRequest, e.Message, LogLevel.Warning),
            [typeof(InvalidTokenException)] = (e) => new ResponseDetails(HttpStatusCode.BadRequest, e.Message, LogLevel.Error),
            [typeof(InvalidCredentialsException)] = (e) => new ResponseDetails(HttpStatusCode.Unauthorized, e.Message, LogLevel.Error)
        };
    }

    public static ResponseDetails GetInfo(this Exception exception)
    {
        if (exception == null)
        {
            throw new Exception("Exception can't be null");
        }

        var exceptionType = exception.GetType();
        return StatusesMapper.ContainsKey(exceptionType) ? StatusesMapper[exceptionType](exception) : new ResponseDetails(HttpStatusCode.InternalServerError, "Internal server error");
    }
}
