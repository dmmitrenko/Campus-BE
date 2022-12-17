﻿using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(n => n.Id);
        builder.HasIndex(n => n.Title).IsUnique();

        builder.Property(x => x.Title).IsRequired();
    }
}
