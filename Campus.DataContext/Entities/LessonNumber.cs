namespace Campus.DataContext.Entities;
public class LessonNumber
{
    public int Number { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public TimeTable TimeTable { get; set; }
}
