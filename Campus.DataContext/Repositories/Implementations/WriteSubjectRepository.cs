using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.DataContext.Repositories.Implementations;
public class WriteSubjectRepository : WriteRepository<Lesson>, IWriteSubjectRepository
{
    public WriteSubjectRepository(
        ILogger logger,
        CampusDbContext context) : base(logger, context)
    {
    }
}
