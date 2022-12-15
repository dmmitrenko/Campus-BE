namespace Campus.Domain.Exceptions;
public class CampusException : Exception
{
    public CampusException(string? message) : base(message)
    {
    }
}
