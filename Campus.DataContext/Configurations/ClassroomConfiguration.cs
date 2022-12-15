using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
{
    public void Configure(EntityTypeBuilder<Classroom> builder)
    {
        builder.HasKey(n => n.Id);
        builder.HasIndex(n => n.Title).IsUnique();

        builder.Property(n => n.Title).IsRequired();
        builder.Property(n => n.Grade).IsRequired();
        builder.Property(n => n.SemesterStartDate).IsRequired();

        builder.HasMany(x => x.Schedules)
            .WithOne(x => x.Classroom)
            .HasForeignKey(x => x.ClassroomId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}
