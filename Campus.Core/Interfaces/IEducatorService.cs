using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface IEducatorService
{
    Task<Educator> AddTeacherAsync(Educator teacherModel);
    Task<IEnumerable<Course>> GetTeacherLessonsAsync(Guid teacherId);
    Task<EducatorCourse> AddTeacherLessonsAsync(EducatorCourse teacherLessonsModel);
}
