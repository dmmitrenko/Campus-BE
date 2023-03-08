using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface IEducatorService
{
    Task<TeacherModel> AddTeacherAsync(TeacherModel teacherModel);
    Task<IEnumerable<LessonModel>> GetTeacherLessonsAsync(Guid teacherId);
    Task<TeacherLessonsModel> AddTeacherLessonsAsync(TeacherLessonsModel teacherLessonsModel);
}
