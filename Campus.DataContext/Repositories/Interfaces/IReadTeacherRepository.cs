using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;

namespace Campus.DataContext.Repositories.Interfaces;
public interface IReadTeacherRepository : IReadRepository<Teacher>
{
    Task<Teacher?> GetTeacherWithSubjects(Guid teacherId);
}
