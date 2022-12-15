namespace Campus.DataContext.Entities;
public class TimeTable
{
    public int Number { get; set; }
    public Guid LessonId { get; set; }
    public DateOnly Day { get; set; }

    public LessonNumber LessonNumber { get; set; }
    public DailySchedule DailySchedule { get; set; }
    public Lesson Lesson { get; set; }
}
