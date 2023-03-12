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
    public DbSet<Course> Lessons { get; set; }
    public DbSet<TimeTable> LessonNumbers { get; set; }
    public DbSet<Educator> Teachers { get; set; }
    public DbSet<EducatorCourse> TeacherLesson { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed();
    }
}
