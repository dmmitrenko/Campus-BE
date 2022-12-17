using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class LessonNumberConfiguration : IEntityTypeConfiguration<LessonNumber>
{
    public void Configure(EntityTypeBuilder<LessonNumber> builder)
    {
        builder.HasKey(x => x.Number);
        builder.Property(x => x.StartTime).IsRequired();
        builder.Property(x => x.EndTime).IsRequired();

        builder.HasMany(n => n.Schedules)
            .WithOne(n => n.Number)
            .HasForeignKey(n => n.LessonNumber)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
