using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;

namespace Campus.DataContext.Repositories.Interfaces;
public interface IReadSubjectRepository : IReadRepository<Lesson>
{
    Task<Lesson?> GetSubjectWithTeachers(Guid subjectId);
}
