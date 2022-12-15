using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.DataContext.Repositories.Implementations;
public class WriteTeacherLessonsRepository : WriteRepository<TeacherLessons>, IWriteTeacherSubjectRepository
{
    public WriteTeacherLessonsRepository(
        ILogger logger,
        CampusDbContext context) : base(logger, context)
    {
    }
}
