using Campus.DataContext.Entities;
using Campus.DataContext.SeedData;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Campus.DataContext;
public class CampusDbContext : DbContext
{
    public CampusDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<LessonNumber> LessonNumbers { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherLessons> TeacherLesson { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed();
    }
}
