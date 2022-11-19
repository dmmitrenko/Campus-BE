namespace Campus.Subject.DataContext.Entities;
public class Classroom
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Grade { get; set; }
    public DateOnly SemesterStartDate { get; set; }

    public IEnumerable<DailySchedule> Schedules { get; set; }
}
