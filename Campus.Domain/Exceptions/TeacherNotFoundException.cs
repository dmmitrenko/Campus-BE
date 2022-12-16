namespace Campus.Domain.Exceptions;
public class TeacherNotFoundException : CampusException
{
    public TeacherNotFoundException(Guid id) 
        : base($"Teacher with id: {id} not found")
    {
    }
}
