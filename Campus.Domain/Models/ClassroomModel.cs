namespace Campus.Domain.Models;
public class ClassroomModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Grade { get; set; }
    public DateOnly SemesterStartDate { get; set; }

    public IEnumerable<DailyScheduleModel> Schedules { get; set; }
}
