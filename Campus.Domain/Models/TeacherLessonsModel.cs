namespace Campus.Domain.Models;
public class TeacherLessonsModel
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public Guid TeacherId { get; set; }

    public ScheduleModel Schedule { get; set; }
    public TeacherModel Teacher { get; set; }
    public LessonModel Lesson { get; set; }
}
