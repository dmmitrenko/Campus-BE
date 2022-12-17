namespace Campus.Domain.Models;
public class ScheduleModel
{
    public DateOnly Date { get; set; }
    public int LessonNumber { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public int WeekNumber { get; set; }
    public Guid ClassroomId { get; set; }
    public Guid TeacherLessonId { get; set; }

    public ClassroomModel Classroom { get; set; }
    public LessonNumberModel Number { get; set; }
    public TeacherLessonsModel TeacherLessons { get; set; }
}
