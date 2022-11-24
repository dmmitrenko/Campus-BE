using Campus.Subject.Domain.Models;

namespace Campus.Subject.Core.Interfaces;
public interface ISubjectService
{
    Task<LessonModel> AddSubjectAsync(LessonModel lessonModel);
    Task<IEnumerable<TeacherModel>> GetTeachersForLessonAsync(Guid lessonId);
}
