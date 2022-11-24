using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class ReadSubjectRepository : ReadRepository<Lesson>, IReadSubjectRepository
{
    public ReadSubjectRepository(CampusDbContext context) : base(context)
    {
    }
}
