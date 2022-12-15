using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class WriteClassRepository : WriteRepository<Classroom>, IWriteClassRepository
{
    public WriteClassRepository(ILogger logger, CampusDbContext context) : base(logger, context)
    {
    }
}
