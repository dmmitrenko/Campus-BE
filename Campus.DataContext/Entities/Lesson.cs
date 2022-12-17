namespace Campus.DataContext.Entities;
public class Lesson
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<TeacherLessons> TeacherLessons { get; set; }
}
