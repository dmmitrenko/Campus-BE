using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class TimeTableConfiguration : IEntityTypeConfiguration<TimeTable>
{
    public void Configure(EntityTypeBuilder<TimeTable> builder)
    {
        builder.HasKey(n => n.Number);

        builder.HasOne(x => x.LessonNumber)
            .WithOne(x => x.TimeTable)
            .HasForeignKey<TimeTable>(x => x.Number)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
