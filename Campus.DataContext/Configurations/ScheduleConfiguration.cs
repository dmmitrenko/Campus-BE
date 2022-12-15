using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
internal class ScheduleConfiguration : IEntityTypeConfiguration<DailySchedule>
{
    public void Configure(EntityTypeBuilder<DailySchedule> builder)
    {
        builder.HasKey(n => n.Date);

        builder.Property(n => n.Date).HasColumnType("date").IsRequired();
        builder.Property(n => n.DayOfWeek).HasConversion<string>().IsRequired();
        builder.Property(n => n.ClassroomId).IsRequired();
        builder.Property(n => n.WeekNumber).IsRequired();

        builder.HasMany(x => x.Times)
            .WithOne(x => x.DailySchedule)
            .HasForeignKey(x => x.Day)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
