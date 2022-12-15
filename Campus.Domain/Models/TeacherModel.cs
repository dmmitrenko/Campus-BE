namespace Campus.Domain.Models;
public class TeacherModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public IEnumerable<TeacherLessonsModel> TeacherLessons { get; set; }
}
