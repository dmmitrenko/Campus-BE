using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class ReadTeacherRepository : ReadRepository<Teacher>, IReadTeacherRepository
{
    public ReadTeacherRepository(
        CampusDbContext context) : base(context)
    {
    }
}
