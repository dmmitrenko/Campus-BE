namespace Campus.DataContext.Entities;
public class DailySchedule
{
    public DateOnly Date { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public int WeekNumber { get; set; }
    public Guid ClassroomId { get; set; }

    public Classroom Classroom { get; set; }
    public IEnumerable<TimeTable> Times { get; set; }
}
