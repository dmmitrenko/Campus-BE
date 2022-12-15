using Campus.DataContext;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Campus.DataContext.Repositories.Implementations;
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
