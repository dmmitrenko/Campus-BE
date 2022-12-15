using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Campus.DataContext;
public class CampusDbContext : DbContext
{
    public CampusDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<DailySchedule> Schedules { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<LessonNumber> LessonNumbers { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherLessons> TeacherLesson { get; set; }
    public DbSet<TimeTable> TimeTables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
