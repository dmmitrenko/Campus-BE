namespace Campus.Domain.Models;
public class Classroom
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Grade { get; set; }
    public DateOnly SemesterStartDate { get; set; }
    public DateOnly SemesterEndDate { get; set; }
    public int SemesterNumber { get; set; }

    public IEnumerable<Schedule> Schedules { get; set; }
}
