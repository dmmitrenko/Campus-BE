using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.DataContext.Repositories.Implementations;
public class WriteEducatorCourseRepository : WriteRepository<EducatorCourse>, IWriteEducatorCourseRepository
{
    public WriteEducatorCourseRepository(
        ILogger logger,
        CampusDbContext context) : base(logger, context)
    {
    }
}
