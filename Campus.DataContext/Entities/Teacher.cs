namespace Campus.DataContext.Entities;
public class Teacher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public IEnumerable<TeacherLessons> TeacherLessons { get; set; }
}
