using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;

namespace Campus.DataContext.Repositories.Implementations;
public class ReadClassRepository : ReadRepository<Classroom>, IReadClassRepository
{
    public ReadClassRepository(CampusDbContext context) : base(context)
    {
    }
}
