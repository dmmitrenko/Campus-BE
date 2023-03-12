using System.Xml;

namespace Campus.Domain.Models;
public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<EducatorCourse> TeacherLessons { get; set; }
}
