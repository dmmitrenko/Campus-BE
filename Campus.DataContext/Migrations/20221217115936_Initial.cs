using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Campus.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    SemesterStartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SemesterEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SemesterNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonNumbers",
                columns: table => new
                {
                    Number = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonNumbers", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLesson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherLesson_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeacherLesson_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    LessonNumber = table.Column<int>(type: "integer", nullable: false),
                    ClassroomId = table.Column<Guid>(type: "uuid", nullable: false),
                    DayOfWeek = table.Column<string>(type: "text", nullable: false),
                    WeekNumber = table.Column<int>(type: "integer", nullable: false),
                    TeacherLessonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => new { x.Date, x.LessonNumber, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_Schedules_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_LessonNumbers_LessonNumber",
                        column: x => x.LessonNumber,
                        principalTable: "LessonNumbers",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_TeacherLesson_TeacherLessonId",
                        column: x => x.TeacherLessonId,
                        principalTable: "TeacherLesson",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Grade", "SemesterEndDate", "SemesterNumber", "SemesterStartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"), 4, new DateOnly(2023, 1, 20), 7, new DateOnly(2022, 9, 5), "PB-91" },
                    { new Guid("c0250e44-a109-410e-b065-12aa409c2779"), 2, new DateOnly(2023, 1, 20), 3, new DateOnly(2022, 9, 5), "FI-01" }
                });

            migrationBuilder.InsertData(
                table: "LessonNumbers",
                columns: new[] { "Number", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, new TimeOnly(10, 5, 0), new TimeOnly(8, 30, 0) },
                    { 2, new TimeOnly(12, 0, 0), new TimeOnly(10, 25, 0) },
                    { 3, new TimeOnly(13, 55, 0), new TimeOnly(12, 20, 0) },
                    { 4, new TimeOnly(15, 50, 0), new TimeOnly(14, 15, 0) },
                    { 5, new TimeOnly(17, 45, 0), new TimeOnly(16, 10, 0) },
                    { 6, new TimeOnly(20, 5, 0), new TimeOnly(18, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f"), "Robotics" },
                    { new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d"), "Automation" },
                    { new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09"), "Economy" },
                    { new Guid("3bf678aa-4727-488c-841f-e808ed055f41"), "Optical medical devices" },
                    { new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4"), "Algorithms and data structures" },
                    { new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180"), "Computational Mathematics" },
                    { new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25"), "Programming in C++ language" },
                    { new Guid("bae325f3-2925-4191-8a80-7a8797fa7948"), "Software Engineering" },
                    { new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c"), "Analytic geometry" },
                    { new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7"), "Image processing" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee"), "shevchenko@gmail.com", "Vadym", "Shevchenko", "Volodymyrovych" },
                    { new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016"), "tymchyk@gmail.com", "Hryhorii", "Tymchyk", "Semenovych" },
                    { new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06"), "bezuhla@gmail.com", "Nataliia", "Bezuhla", "Vasylivna" },
                    { new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e"), "bezuhlyi@gmail.com", "Mykhailo", "Bezuhlyi", "Oleksandrovych" },
                    { new Guid("d0605896-ac68-40ef-9aa1-4db03766abef"), "barandych@gmail.com", "Kateryna", "Barandych", "Serhiivna" }
                });

            migrationBuilder.InsertData(
                table: "TeacherLesson",
                columns: new[] { "Id", "LessonId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("059810f7-9e46-42fd-81cb-851f0072915b"), new Guid("b8afa133-1654-4463-93ce-52efc1f5ad25"), new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e") },
                    { new Guid("1983445d-8354-440c-b32f-c6105c05380b"), new Guid("44c35e30-a1c4-4446-bccf-ba5614f01ef4"), new Guid("7ea2de2a-ed39-453f-a52d-d99649f5d75e") },
                    { new Guid("25a89400-d659-440a-9e98-a10319be9402"), new Guid("90e0cb8e-e0c9-4ccd-af0a-cd816eff8180"), new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016") },
                    { new Guid("5365d979-021f-4b3c-b25d-356a1c697d1c"), new Guid("3bf678aa-4727-488c-841f-e808ed055f41"), new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee") },
                    { new Guid("65a4b719-899c-49e7-a64c-352f82aed694"), new Guid("260e2db8-d632-4429-9900-0d153fd7fe8d"), new Guid("4a86c8cc-06c1-4183-8ca3-36a5c480f016") },
                    { new Guid("95790929-4073-4d16-aded-e76adceaa12f"), new Guid("e6a00bbb-b505-4a2a-8e7d-8b22e0b461a7"), new Guid("d0605896-ac68-40ef-9aa1-4db03766abef") },
                    { new Guid("ae9077f1-d038-457f-9a7c-6cb1afea3dee"), new Guid("22a0ac65-fbe2-4985-ad83-14a34803320f"), new Guid("06bdcef2-61a0-42b5-9376-4228eac326ee") },
                    { new Guid("d054e93e-c24d-4f8c-bcd8-bb3f28fc788b"), new Guid("bae325f3-2925-4191-8a80-7a8797fa7948"), new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06") },
                    { new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8"), new Guid("3b2041e6-4dc9-47f3-ab63-b47007cc3a09"), new Guid("5bbdee51-fca5-4023-b2dc-f42ea4d23b06") },
                    { new Guid("e91ec4a2-cbc9-43ea-99a9-59e9ec8df8c9"), new Guid("e05151cf-2326-4133-b0dc-b9f1a7c3bd4c"), new Guid("d0605896-ac68-40ef-9aa1-4db03766abef") }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ClassroomId", "Date", "LessonNumber", "DayOfWeek", "TeacherLessonId", "WeekNumber" },
                values: new object[,]
                {
                    { new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"), new DateOnly(2022, 12, 19), 1, "Monday", new Guid("65a4b719-899c-49e7-a64c-352f82aed694"), 1 },
                    { new Guid("c0250e44-a109-410e-b065-12aa409c2779"), new DateOnly(2022, 12, 19), 1, "Monday", new Guid("25a89400-d659-440a-9e98-a10319be9402"), 1 },
                    { new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"), new DateOnly(2022, 12, 19), 2, "Monday", new Guid("d63bda59-d745-46e5-a2ef-bcb4e8ad70c8"), 1 },
                    { new Guid("2c677e62-3c50-4b0b-99bb-57304e927453"), new DateOnly(2022, 12, 19), 3, "Monday", new Guid("1983445d-8354-440c-b32f-c6105c05380b"), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_Title",
                table: "Classrooms",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_Title",
                table: "Lessons",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ClassroomId",
                table: "Schedules",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_LessonNumber",
                table: "Schedules",
                column: "LessonNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TeacherLessonId",
                table: "Schedules",
                column: "TeacherLessonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLesson_LessonId",
                table: "TeacherLesson",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLesson_TeacherId",
                table: "TeacherLesson",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "LessonNumbers");

            migrationBuilder.DropTable(
                name: "TeacherLesson");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
