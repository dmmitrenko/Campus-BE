namespace Campus.Subject.Domain.Models;
public class LessonNumberModel
{
    public int Number { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public TimeTableModel TimeTable { get; set; }
}
