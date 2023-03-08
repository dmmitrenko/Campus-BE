using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface ICourseService
{
    Task<LessonModel> AddSubjectAsync(LessonModel lessonModel);
    Task<IEnumerable<TeacherModel>> GetTeachersForLessonAsync(Guid lessonId);
}
