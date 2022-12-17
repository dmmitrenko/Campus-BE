namespace Campus.DataContext.Entities;
public class TeacherLessons
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public Guid TeacherId { get; set; }

    public Schedule Schedule { get; set; }  
    public Teacher Teacher { get; set; }
    public Lesson Lesson { get; set; }
}
