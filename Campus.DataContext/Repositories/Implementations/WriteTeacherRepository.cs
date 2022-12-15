using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.DataContext.Repositories.Implementations;
public class WriteTeacherRepository : WriteRepository<Teacher>, IWriteTeacherRepository
{
    public WriteTeacherRepository(
        ILogger logger,
        CampusDbContext context) : base(logger, context)
    {
    }
}
