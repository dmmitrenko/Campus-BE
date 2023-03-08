using Campus.Domain.ErrorModels;

namespace Campus.Domain.Exceptions;
public class ValidationException : Exception
{
    public ValidationException(string message) 
        : base(message)
    {
    }

    public ValidationException(string message, IList<ValidationError> errors) : base(message)
    {
        Errors = errors;
    }

    public IList<ValidationError> Errors { get; set; }
}
