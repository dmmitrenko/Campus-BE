using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Base;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Campus.DataContext.Repositories.Implementations;
public class ReadCourseRepository : ReadRepository<Course>, IReadCourseRepository
{
    public ReadCourseRepository(CampusDbContext context) : base(context)
    {
    }

    public async Task<Course?> GetSubjectWithTeachers(Guid subjectId)
    {
        return await _dbSet.AsNoTracking()
            .Include(n => n.TeacherLessons)
            .ThenInclude(n => n.Teacher)
            .FirstOrDefaultAsync(n => n.Id == subjectId);
    }
}
