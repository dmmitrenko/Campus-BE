using System.Xml;

namespace Campus.Domain.Models;
public class LessonModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<TeacherLessonsModel> TeacherLessons { get; set; }
}
