namespace Campus.Subject.Domain.Models;
public class TimeTableModel
{
    public int Number { get; set; }
    public Guid LessonId { get; set; }
    public DateOnly Day { get; set; }

    public LessonNumberModel LessonNumber { get; set; }
    public DailyScheduleModel DailySchedule { get; set; }
    public LessonModel Lesson { get; set; }
}
