namespace Campus.Subject.Domain.Models;
public class TeacherLessonsModel
{
    public Guid LessonId { get; set; }
    public Guid TeacherId { get; set; }

    public TeacherModel Teacher { get; set; }
    public LessonModel Lesson { get; set; }
}
