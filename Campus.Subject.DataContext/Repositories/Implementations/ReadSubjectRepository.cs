using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Campus.Subject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class ReadSubjectRepository : ReadRepository<Lesson>, IReadSubjectRepository
{
    public ReadSubjectRepository(CampusDbContext context) : base(context)
    {
    }

    public async Task<Lesson?> GetSubjectWithTeachers(Guid subjectId)
    {
        return await _dbSet.AsNoTracking()
            .Include(n => n.TeacherLessons)
            .ThenInclude(n => n.Teacher)
            .FirstOrDefaultAsync(n => n.Id == subjectId);
    }
}
