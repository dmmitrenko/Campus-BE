using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.DataContext.Repositories.Interfaces;
public interface IReadSubjectRepository : IReadRepository<Lesson>
{
    Task<Lesson?> GetSubjectWithTeachers(Guid subjectId);
}
