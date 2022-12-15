using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class ReadClassRepository : ReadRepository<Classroom>, IReadClassRepository
{
    public ReadClassRepository(CampusDbContext context) : base(context)
    {
    }
}
