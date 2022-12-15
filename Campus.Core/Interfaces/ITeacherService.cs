using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface ITeacherService
{
    Task<TeacherModel> AddTeacherAsync(TeacherModel teacherModel);
    Task<IEnumerable<LessonModel>> GetTeacherLessonsAsync(Guid teacherId);
    Task<TeacherLessonsModel> AddTeacherLessonsAsync(TeacherLessonsModel teacherLessonsModel);
}
