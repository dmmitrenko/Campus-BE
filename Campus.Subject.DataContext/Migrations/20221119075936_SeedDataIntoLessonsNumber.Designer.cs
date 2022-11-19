﻿// <auto-generated />
using System;
using Campus.Subject.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Campus.Subject.DataContext.Migrations
{
    [DbContext(typeof(CampusDbContext))]
    [Migration("20221119075936_SeedDataIntoLessonsNumber")]
    partial class SeedDataIntoLessonsNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Classroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("SemesterStartDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.DailySchedule", b =>
                {
                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("ClassroomId")
                        .HasColumnType("uuid");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("integer");

                    b.HasKey("Date");

                    b.HasIndex("ClassroomId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.LessonNumber", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Number"));

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time without time zone");

                    b.HasKey("Number");

                    b.ToTable("LessonNumbers");

                    b.HasData(
                        new
                        {
                            Number = 1,
                            EndTime = new TimeOnly(10, 5, 0),
                            StartTime = new TimeOnly(8, 30, 0)
                        },
                        new
                        {
                            Number = 2,
                            EndTime = new TimeOnly(12, 0, 0),
                            StartTime = new TimeOnly(10, 25, 0)
                        },
                        new
                        {
                            Number = 3,
                            EndTime = new TimeOnly(13, 55, 0),
                            StartTime = new TimeOnly(12, 20, 0)
                        },
                        new
                        {
                            Number = 4,
                            EndTime = new TimeOnly(15, 50, 0),
                            StartTime = new TimeOnly(14, 15, 0)
                        },
                        new
                        {
                            Number = 5,
                            EndTime = new TimeOnly(17, 45, 0),
                            StartTime = new TimeOnly(16, 10, 0)
                        },
                        new
                        {
                            Number = 6,
                            EndTime = new TimeOnly(20, 5, 0),
                            StartTime = new TimeOnly(18, 30, 0)
                        });
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.TeacherLessons", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("uuid");

                    b.HasKey("TeacherId", "LessonId");

                    b.HasIndex("LessonId");

                    b.ToTable("TeacherLesson");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.TimeTable", b =>
                {
                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Day")
                        .HasColumnType("date");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("uuid");

                    b.HasKey("Number");

                    b.HasIndex("Day");

                    b.HasIndex("LessonId");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.DailySchedule", b =>
                {
                    b.HasOne("Campus.Subject.DataContext.Entities.Classroom", "Classroom")
                        .WithMany("Schedules")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.TeacherLessons", b =>
                {
                    b.HasOne("Campus.Subject.DataContext.Entities.Lesson", "Lesson")
                        .WithMany("TeacherLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Campus.Subject.DataContext.Entities.Teacher", "Teacher")
                        .WithMany("TeacherLessons")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.TimeTable", b =>
                {
                    b.HasOne("Campus.Subject.DataContext.Entities.DailySchedule", "DailySchedule")
                        .WithMany("Times")
                        .HasForeignKey("Day")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Campus.Subject.DataContext.Entities.Lesson", "Lesson")
                        .WithMany("TimeTables")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Campus.Subject.DataContext.Entities.LessonNumber", "LessonNumber")
                        .WithOne("TimeTable")
                        .HasForeignKey("Campus.Subject.DataContext.Entities.TimeTable", "Number")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailySchedule");

                    b.Navigation("Lesson");

                    b.Navigation("LessonNumber");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Classroom", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.DailySchedule", b =>
                {
                    b.Navigation("Times");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Lesson", b =>
                {
                    b.Navigation("TeacherLessons");

                    b.Navigation("TimeTables");
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.LessonNumber", b =>
                {
                    b.Navigation("TimeTable")
                        .IsRequired();
                });

            modelBuilder.Entity("Campus.Subject.DataContext.Entities.Teacher", b =>
                {
                    b.Navigation("TeacherLessons");
                });
#pragma warning restore 612, 618
        }
    }
}
