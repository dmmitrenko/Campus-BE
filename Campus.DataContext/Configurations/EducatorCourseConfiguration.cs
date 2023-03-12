using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class EducatorCourseConfiguration : IEntityTypeConfiguration<EducatorCourse>
{
    public void Configure(EntityTypeBuilder<EducatorCourse> builder)
    {
        builder.HasKey(n => n.Id);

        builder.HasOne(x => x.Lesson)
            .WithMany(x => x.TeacherLessons)
            .HasForeignKey(x => x.LessonId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Teacher)
            .WithMany(x => x.TeacherLessons)
            .HasForeignKey(x => x.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
