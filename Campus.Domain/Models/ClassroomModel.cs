namespace Campus.Domain.Models;
public class ClassroomModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Grade { get; set; }
    public DateOnly SemesterStartDate { get; set; }
    public DateOnly SemesterEndDate { get; set; }
    public int SemesterNumber { get; set; }

    public IEnumerable<ScheduleModel> Schedules { get; set; }
}
