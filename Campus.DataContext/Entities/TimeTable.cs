namespace Campus.DataContext.Entities;
public class TimeTable
{
    public int Number { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public IEnumerable<Schedule> Schedules { get; set; }
}
