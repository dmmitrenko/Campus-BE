using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.ExceptionResolvers.Base;

public interface IExceptionResolver<T> : IExceptionResolver where T : Exception
{
}

public interface IExceptionResolver
{
    void OnException(ExceptionContext context);
}