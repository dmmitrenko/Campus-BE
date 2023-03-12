namespace Campus.DataContext.Entities;
public class Schedule
{
    public DateOnly Date { get; set; }
    public int LessonNumber { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public int WeekNumber { get; set; }
    public Guid ClassroomId { get; set; }
    public Guid TeacherLessonId { get; set; }

    public TimeTable Number { get; set; }
    public Classroom Classroom { get; set; }
    public EducatorCourse TeacherLessons { get; set; }
}
