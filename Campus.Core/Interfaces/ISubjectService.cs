using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface ISubjectService
{
    Task<LessonModel> AddSubjectAsync(LessonModel lessonModel);
    Task<IEnumerable<TeacherModel>> GetTeachersForLessonAsync(Guid lessonId);
}
