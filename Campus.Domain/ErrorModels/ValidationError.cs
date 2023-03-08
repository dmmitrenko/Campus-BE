namespace Campus.Domain.ErrorModels;

public class ValidationError
{
    public ValidationError(string field, string errorMessage)
    {
        Field = field;
        ErrorMessage = errorMessage;
    }

    public string Field { get; private set; }
    public string ErrorMessage { get; private set; }
}
