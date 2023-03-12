namespace Campus.Domain.Models;
public class Educator
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public IEnumerable<EducatorCourse> TeacherLessons { get; set; }
}
