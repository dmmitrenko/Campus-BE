namespace Campus.Domain.Exceptions;
public class SubjectNotFoundException : CampusException
{
    public SubjectNotFoundException(Guid id) 
        : base($"Subject with id: {id} not found.")
    {
    }
}
