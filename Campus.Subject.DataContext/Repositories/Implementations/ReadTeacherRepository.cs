using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class ReadTeacherRepository : ReadRepository<Teacher>, IReadTeacherRepository
{
    public ReadTeacherRepository(
        CampusDbContext context) : base(context)
    {
    }

    public async Task<Teacher?> GetTeacherWithSubjects(Guid teacherId)
    {
        return await _dbSet.AsNoTracking()
            .Include(n => n.TeacherLessons)
            .ThenInclude(n => n.Lesson)
            .FirstOrDefaultAsync(n => n.Id == teacherId);
    }
}
