namespace Campus.Domain.Models;
public class LessonNumberModel
{
    public int Number { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public IEnumerable<ScheduleModel> Schedules { get; set; }
}
