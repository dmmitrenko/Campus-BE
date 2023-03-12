using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface ICourseService
{
    Task<Course> AddSubjectAsync(Course lessonModel);
    Task<IEnumerable<Educator>> GetTeachersForLessonAsync(Guid lessonId);
}
