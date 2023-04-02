﻿// <auto-generated />
using System;
using Campus.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Campus.DataContext.Migrations
{
    [DbContext(typeof(CampusDbContext))]
    partial class CampusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Campus.DataContext.Entities.Classroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("SemesterEndDate")
                        .HasColumnType("date");

                    b.Property<int>("SemesterNumber")
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0250e44-a109-410e-b065-12aa409c2779"),
                            Grade = 2,
                            SemesterEndDate = new DateOnly(2023, 1, 20),
                            SemesterNumber = 3,
                            SemesterStartDate = new DateOnly(2022, 9, 5),
                            Title = "FI-01"
                        },
                        new
                        {
                            Id = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                            Grade = 4,
                            SemesterEndDate = new DateOnly(2023, 1, 20),
                            SemesterNumber = 7,
                            SemesterStartDate = new DateOnly(2022, 9, 5),
                            Title = "PB-91"
                        });
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d"),
                            Title = "Automation"
                        },
                        new
                        {
                            Id = new Guid("bae325f3-2925-4191-8a80-7a8797fa7948"),
                            Title = "Software Engineering"
                        },
                        new
                        {
                            Id = new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180"),
                            Title = "Computational Mathematics"
                        },
                        new
                        {
                            Id = new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09"),
                            Title = "Economy"
                        },
                        new
                        {
                            Id = new Guid("3bf678aa-4727-488c-841f-e808ed055f41"),
                            Title = "Optical medical devices"
                        },
                        new
                        {
                            Id = new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7"),
                            Title = "Image processing"
                        },
                        new
                        {
                            Id = new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f"),
                            Title = "Robotics"
                        },
                        new
                        {
                            Id = new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c"),
                            Title = "Analytic geometry"
                        },
                        new
                        {
                            Id = new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4"),
                            Title = "Algorithms and data structures"
                        },
                        new
                        {
                            Id = new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25"),
                            Title = "Programming in C++ language"
                        });
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Educator", b =>
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06"),
                            Email = "bezuhla@gmail.com",
                            FirstName = "Nataliia",
                            LastName = "Bezuhla",
                            MiddleName = "Vasylivna"
                        },
                        new
                        {
                            Id = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016"),
                            Email = "tymchyk@gmail.com",
                            FirstName = "Hryhorii",
                            LastName = "Tymchyk",
                            MiddleName = "Semenovych"
                        },
                        new
                        {
                            Id = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee"),
                            Email = "shevchenko@gmail.com",
                            FirstName = "Vadym",
                            LastName = "Shevchenko",
                            MiddleName = "Volodymyrovych"
                        },
                        new
                        {
                            Id = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e"),
                            Email = "bezuhlyi@gmail.com",
                            FirstName = "Mykhailo",
                            LastName = "Bezuhlyi",
                            MiddleName = "Oleksandrovych"
                        },
                        new
                        {
                            Id = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef"),
                            Email = "barandych@gmail.com",
                            FirstName = "Kateryna",
                            LastName = "Barandych",
                            MiddleName = "Serhiivna"
                        });
                });

            modelBuilder.Entity("Campus.DataContext.Entities.EducatorCourse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherLesson");

                    b.HasData(
                        new
                        {
                            Id = new Guid("65a4b719-899c-49e7-a64c-352f82aed694"),
                            LessonId = new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d"),
                            TeacherId = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016")
                        },
                        new
                        {
                            Id = new Guid("d054e93e-c24d-4f8c-bcd8-bb3f28fc788b"),
                            LessonId = new Guid("bae325f3-2925-4191-8a80-7a8797fa7948"),
                            TeacherId = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06")
                        },
                        new
                        {
                            Id = new Guid("25a89400-d659-440a-9e98-a10319be9402"),
                            LessonId = new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180"),
                            TeacherId = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016")
                        },
                        new
                        {
                            Id = new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8"),
                            LessonId = new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09"),
                            TeacherId = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06")
                        },
                        new
                        {
                            Id = new Guid("5365d979-021f-4b3c-b25d-356a1c697d1c"),
                            LessonId = new Guid("3bf678aa-4727-488c-841f-e808ed055f41"),
                            TeacherId = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee")
                        },
                        new
                        {
                            Id = new Guid("95790929-4073-4d16-aded-e76adceaa12f"),
                            LessonId = new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7"),
                            TeacherId = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef")
                        },
                        new
                        {
                            Id = new Guid("ae9077f1-d038-457f-9a7c-6cb1afea3dee"),
                            LessonId = new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f"),
                            TeacherId = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee")
                        },
                        new
                        {
                            Id = new Guid("e91ec4a2-cbc9-43ea-99a9-59e9ec8df8c9"),
                            LessonId = new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c"),
                            TeacherId = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef")
                        },
                        new
                        {
                            Id = new Guid("1983445d-8354-440c-b32f-c6105c05380b"),
                            LessonId = new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4"),
                            TeacherId = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e")
                        },
                        new
                        {
                            Id = new Guid("059810f7-9e46-42fd-81cb-851f0072915b"),
                            LessonId = new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25"),
                            TeacherId = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e")
                        });
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Schedule", b =>
                {
                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("integer");

                    b.Property<Guid>("ClassroomId")
                        .HasColumnType("uuid");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TeacherLessonId")
                        .HasColumnType("uuid");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("integer");

                    b.HasKey("Date", "LessonNumber", "ClassroomId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("LessonNumber");

                    b.HasIndex("TeacherLessonId")
                        .IsUnique();

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Date = new DateOnly(2022, 12, 19),
                            LessonNumber = 1,
                            ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                            DayOfWeek = "Monday",
                            TeacherLessonId = new Guid("65a4b719-899c-49e7-a64c-352f82aed694"),
                            WeekNumber = 1
                        },
                        new
                        {
                            Date = new DateOnly(2022, 12, 19),
                            LessonNumber = 2,
                            ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                            DayOfWeek = "Monday",
                            TeacherLessonId = new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8"),
                            WeekNumber = 1
                        },
                        new
                        {
                            Date = new DateOnly(2022, 12, 19),
                            LessonNumber = 3,
                            ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                            DayOfWeek = "Monday",
                            TeacherLessonId = new Guid("1983445d-8354-440c-b32f-c6105c05380b"),
                            WeekNumber = 1
                        },
                        new
                        {
                            Date = new DateOnly(2022, 12, 19),
                            LessonNumber = 1,
                            ClassroomId = new Guid("c0250e44-a109-410e-b065-12aa409c2779"),
                            DayOfWeek = "Monday",
                            TeacherLessonId = new Guid("25a89400-d659-440a-9e98-a10319be9402"),
                            WeekNumber = 1
                        });
                });

            modelBuilder.Entity("Campus.DataContext.Entities.TimeTable", b =>
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

            modelBuilder.Entity("Campus.DataContext.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d8ddbd54-1ab5-482b-936a-e38f8665a4f9",
                            ConcurrencyStamp = "9ad4cf59-4f13-4b4e-a668-29d6f6b4e2c2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "dc6e8162-5a19-4921-9bc1-930db7130796",
                            ConcurrencyStamp = "783d665f-efcd-45ac-a607-8d4f1924a033",
                            Name = "Educator",
                            NormalizedName = "EDUCATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Campus.DataContext.Entities.EducatorCourse", b =>
                {
                    b.HasOne("Campus.DataContext.Entities.Course", "Lesson")
                        .WithMany("TeacherLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Campus.DataContext.Entities.Educator", "Teacher")
                        .WithMany("TeacherLessons")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Schedule", b =>
                {
                    b.HasOne("Campus.DataContext.Entities.Classroom", "Classroom")
                        .WithMany("Schedules")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Campus.DataContext.Entities.TimeTable", "Number")
                        .WithMany("Schedules")
                        .HasForeignKey("LessonNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Campus.DataContext.Entities.EducatorCourse", "TeacherLessons")
                        .WithOne("Schedule")
                        .HasForeignKey("Campus.DataContext.Entities.Schedule", "TeacherLessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Number");

                    b.Navigation("TeacherLessons");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Campus.DataContext.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Campus.DataContext.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Campus.DataContext.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Campus.DataContext.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Classroom", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Course", b =>
                {
                    b.Navigation("TeacherLessons");
                });

            modelBuilder.Entity("Campus.DataContext.Entities.Educator", b =>
                {
                    b.Navigation("TeacherLessons");
                });

            modelBuilder.Entity("Campus.DataContext.Entities.EducatorCourse", b =>
                {
                    b.Navigation("Schedule")
                        .IsRequired();
                });

            modelBuilder.Entity("Campus.DataContext.Entities.TimeTable", b =>
                {
                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
