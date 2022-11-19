using Campus.Subject.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.Subject.DataContext.Configurations;
public class LessonNumberConfiguration : IEntityTypeConfiguration<LessonNumber>
{
    public void Configure(EntityTypeBuilder<LessonNumber> builder)
    {
        builder.HasKey(x => x.Number);
        builder.Property(x => x.StartTime).IsRequired();
        builder.Property(x => x.EndTime).IsRequired();

        builder.HasData(
            new LessonNumber { Number = 1, StartTime = new TimeOnly(8, 30), EndTime = new TimeOnly(10, 5)},
            new LessonNumber { Number = 2, StartTime = new TimeOnly(10, 25), EndTime = new TimeOnly(12, 0) },
            new LessonNumber { Number = 3, StartTime = new TimeOnly(12, 20), EndTime = new TimeOnly(13, 55) },
            new LessonNumber { Number = 4, StartTime = new TimeOnly(14, 15), EndTime = new TimeOnly(15, 50) },
            new LessonNumber { Number = 5, StartTime = new TimeOnly(16, 10), EndTime = new TimeOnly(17, 45) },
            new LessonNumber { Number = 6, StartTime = new TimeOnly(18, 30), EndTime = new TimeOnly(20, 5) });
    }
}
