using Campus.Domain.ErrorModels;
using Campus.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Campus.API.Filters;

public class ValidationActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) 
    {
        if(!context.ModelState.IsValid)
        {
            var errors = new List<ValidationError>();
            foreach (var key in context.ModelState.Keys)
            {
                foreach (var error in context.ModelState[key].Errors)
                {
                    errors.Add(new ValidationError(key, error.ErrorMessage));
                }
            }

            throw new ValidationException("Validation errors occurred", errors);
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }
}