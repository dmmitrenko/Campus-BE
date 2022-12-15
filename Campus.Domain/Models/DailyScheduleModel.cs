using System.Xml;

namespace Campus.Domain.Models;
public class DailyScheduleModel
{
    public DateOnly Date { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public int WeekNumber { get; set; }
    public Guid ClassroomId { get; set; }

    public ClassroomModel Classroom { get; set; }
    public IEnumerable<TimeTableModel> Times { get; set; }
}
