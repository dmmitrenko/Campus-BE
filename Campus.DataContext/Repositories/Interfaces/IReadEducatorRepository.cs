using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;

namespace Campus.DataContext.Repositories.Interfaces;
public interface IReadEducatorRepository : IReadRepository<Educator>
{
    Task<Educator?> GetTeacherWithSubjects(Guid teacherId);
}
