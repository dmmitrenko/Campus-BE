namespace Campus.DataContext.Entities;
public class EducatorCourse
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public Guid TeacherId { get; set; }

    public Schedule Schedule { get; set; }  
    public Educator Teacher { get; set; }
    public Course Lesson { get; set; }
}
