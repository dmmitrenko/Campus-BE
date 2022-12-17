using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
internal class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.HasKey(n => new { n.Date, n.LessonNumber, n.ClassroomId });

        builder.Property(n => n.Date).HasColumnType("date").IsRequired();
        builder.Property(n => n.DayOfWeek).HasConversion<string>().IsRequired();
        builder.Property(n => n.WeekNumber).IsRequired();
        builder.Property(n => n.TeacherLessonId).IsRequired();

        builder.HasOne(n => n.TeacherLessons)
            .WithOne(n => n.Schedule)
            .HasForeignKey<Schedule>(n => n.TeacherLessonId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
