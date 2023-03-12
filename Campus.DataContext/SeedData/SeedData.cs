using Campus.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.SeedData;
public static class SeedData
{
    public static void Seed(this ModelBuilder builder)
    {
        SeedClassrooms(builder.Entity<Classroom>());
        SeedTeachers(builder.Entity<Educator>());
        SeedLessons(builder.Entity<Course>());
        SeedLessonNumber(builder.Entity<TimeTable>());
        SeedTeacherLessons(builder.Entity<EducatorCourse>());
        SeedSchedule(builder.Entity<Schedule>());
    }

    public static void SeedClassrooms(EntityTypeBuilder<Classroom> builder)
    {
        builder.HasData(
            new Classroom
            {
                Id = new Guid("c0250e44-a109-410e-b065-12aa409c2779"),
                Title = "FI-01",
                Grade = 2,
                SemesterStartDate = new DateOnly(2022, 9, 5),
                SemesterEndDate = new DateOnly(2023, 1, 20),
                SemesterNumber = 3
            },
            new Classroom
            {
                Id = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                Title = "PB-91",
                Grade = 4,
                SemesterStartDate = new DateOnly(2022, 9, 5),
                SemesterEndDate = new DateOnly(2023, 1, 20),
                SemesterNumber = 7
            });
    }

    public static void SeedTeachers(EntityTypeBuilder<Educator> builder)
    {
        builder.HasData(
            new Educator
            {
            Id = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06"),
            FirstName = "Nataliia",
            LastName = "Bezuhla",
            MiddleName = "Vasylivna",
            Email = "bezuhla@gmail.com"
            },
            new Educator
            {
                Id = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016"),
                FirstName = "Hryhorii",
                LastName = "Tymchyk",
                MiddleName = "Semenovych",
                Email = "tymchyk@gmail.com"
            },
            new Educator
            {
                Id = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee"),
                FirstName = "Vadym",
                LastName = "Shevchenko",
                MiddleName = "Volodymyrovych",
                Email = "shevchenko@gmail.com"
            },
            new Educator
            {
                Id = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e"),
                FirstName = "Mykhailo",
                LastName = "Bezuhlyi",
                MiddleName = "Oleksandrovych",
                Email = "bezuhlyi@gmail.com"
            },
            new Educator
            {
                Id = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef"),
                FirstName = "Kateryna",
                LastName = "Barandych",
                MiddleName = "Serhiivna",
                Email = "barandych@gmail.com"
            });
    }
    
    public static void SeedLessons(EntityTypeBuilder<Course> builder)
    {
        builder.HasData(
            new Course
            {
                Id = new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d"),
                Title = "Automation"
            },
            new Course
            {
                Id = new Guid("bae325f3-2925-4191-8a80-7a8797fa7948"),
                Title = "Software Engineering"
            },
            new Course
            {
                Id = new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180"),
                Title = "Computational Mathematics"
            },
            new Course
            {
                Id = new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09"),
                Title = "Economy"
            },
            new Course
            {
                Id = new Guid("3bf678aa-4727-488c-841f-e808ed055f41"),
                Title = "Optical medical devices"
            },
            new Course
            {
                Id = new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7"),
                Title = "Image processing"
            },
            new Course
            {
                Id = new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f"),
                Title = "Robotics"
            },
            new Course
            {
                Id = new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c"),
                Title = "Analytic geometry"
            },
            new Course
            {
                Id = new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4"),
                Title = "Algorithms and data structures"
            },
            new Course
            {
                Id = new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25"),
                Title = "Programming in C++ language"
            });
    }

    public static void SeedLessonNumber(EntityTypeBuilder<TimeTable> builder)
    {
        builder.HasData(
            new TimeTable { Number = 1, StartTime = new TimeOnly(8, 30), EndTime = new TimeOnly(10, 5) },
            new TimeTable { Number = 2, StartTime = new TimeOnly(10, 25), EndTime = new TimeOnly(12, 0) },
            new TimeTable { Number = 3, StartTime = new TimeOnly(12, 20), EndTime = new TimeOnly(13, 55) },
            new TimeTable { Number = 4, StartTime = new TimeOnly(14, 15), EndTime = new TimeOnly(15, 50) },
            new TimeTable { Number = 5, StartTime = new TimeOnly(16, 10), EndTime = new TimeOnly(17, 45) },
            new TimeTable { Number = 6, StartTime = new TimeOnly(18, 30), EndTime = new TimeOnly(20, 5) });
    }

    public static void SeedTeacherLessons(EntityTypeBuilder<EducatorCourse> builder)
    {
        builder.HasData(
            new EducatorCourse
            {
                Id = new Guid("65a4b719-899c-49e7-a64c-352f82aed694"),
                TeacherId = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016"),
                LessonId = new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d")
            },
            new EducatorCourse
            {
                Id = new Guid("d054e93e-c24d-4f8c-bcd8-bb3f28fc788b"),
                TeacherId = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06"),
                LessonId = new Guid("bae325f3-2925-4191-8a80-7a8797fa7948")
            },
            new EducatorCourse
            {
                Id = new Guid("25a89400-d659-440a-9e98-a10319be9402"),
                TeacherId = new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016"),
                LessonId = new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180")
            },
            new EducatorCourse
            {
                Id = new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8"),
                TeacherId = new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06"),
                LessonId = new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09")
            },
            new EducatorCourse
            {
                Id = new Guid("5365d979-021f-4b3c-b25d-356a1c697d1c"),
                TeacherId = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee"),
                LessonId = new Guid("3bf678aa-4727-488c-841f-e808ed055f41")
            },
            new EducatorCourse
            {
                Id = new Guid("95790929-4073-4d16-aded-e76adceaa12f"),
                TeacherId = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef"),
                LessonId = new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7")
            },
            new EducatorCourse
            {
                Id = new Guid("ae9077f1-d038-457f-9a7c-6cb1afea3dee"),
                TeacherId = new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee"),
                LessonId = new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f")
            },
            new EducatorCourse
            {
                Id = new Guid("e91ec4a2-cbc9-43ea-99a9-59e9ec8df8c9"),
                TeacherId = new Guid("d0605896-ac68-40ef-9aa1-4db03766abef"),
                LessonId = new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c")
            },
            new EducatorCourse
            {
                Id = new Guid("1983445d-8354-440c-b32f-c6105c05380b"),
                TeacherId = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e"),
                LessonId = new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4")
            },
            new EducatorCourse
            {
                Id = new Guid("059810f7-9e46-42fd-81cb-851f0072915b"),
                TeacherId = new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e"),
                LessonId = new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25")
            });
    }

    public static void SeedSchedule(EntityTypeBuilder<Schedule> builder)
    {
        builder.HasData(
            new Schedule
            {
                Date = new DateOnly(2022, 12, 19),
                LessonNumber = 1,
                DayOfWeek = DayOfWeek.Monday,
                WeekNumber = 1,
                ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                TeacherLessonId = new Guid("65a4b719-899c-49e7-a64c-352f82aed694")
            },
            new Schedule
            {
                Date = new DateOnly(2022, 12, 19),
                LessonNumber = 2,
                DayOfWeek = DayOfWeek.Monday,
                WeekNumber = 1,
                ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                TeacherLessonId = new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8")
            },
            new Schedule
            {
                Date = new DateOnly(2022, 12, 19),
                LessonNumber = 3,
                DayOfWeek = DayOfWeek.Monday,
                WeekNumber = 1,
                ClassroomId = new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"),
                TeacherLessonId = new Guid("1983445d-8354-440c-b32f-c6105c05380b")
            },
            new Schedule
            {
                Date = new DateOnly(2022, 12, 19),
                LessonNumber = 1,
                DayOfWeek = DayOfWeek.Monday,
                WeekNumber = 1,
                ClassroomId = new Guid("c0250e44-a109-410e-b065-12aa409c2779"),
                TeacherLessonId = new Guid("25a89400-d659-440a-9e98-a10319be9402")
            });
    }
}
