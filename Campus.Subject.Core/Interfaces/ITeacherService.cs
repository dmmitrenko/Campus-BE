using Campus.Subject.Domain.Models;

namespace Campus.Subject.Core.Interfaces;
public interface ITeacherService
{
    Task<TeacherModel> AddTeacherAsync(TeacherModel teacherModel);
    Task<IEnumerable<LessonModel>> GetTeacherLessonsAsync(Guid teacherId);
    Task<TeacherLessonsModel> AddTeacherLessonsAsync(TeacherLessonsModel teacherLessonsModel);
}
