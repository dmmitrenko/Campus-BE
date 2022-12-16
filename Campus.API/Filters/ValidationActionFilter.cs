using Campus.API.Models.ErrorResponses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.Filters;

public class ValidationActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) 
    {
        if(!context.ModelState.IsValid)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new ObjectResult(new ErrorModel()
            {
                Message = "Validation error.",
                Body = context.ModelState.Select(x => new ValidationErrorResponse()
                {
                    Field = x.Key,
                    Details = x.Value?.Errors.Select(e => e.ErrorMessage).FirstOrDefault()
                }),
                StatusCode = StatusCodes.Status400BadRequest
            });
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }
}