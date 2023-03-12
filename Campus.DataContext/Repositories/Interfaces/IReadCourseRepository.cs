using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;

namespace Campus.DataContext.Repositories.Interfaces;
public interface IReadCourseRepository : IReadRepository<Course>
{
    Task<Course?> GetSubjectWithTeachers(Guid subjectId);
}
