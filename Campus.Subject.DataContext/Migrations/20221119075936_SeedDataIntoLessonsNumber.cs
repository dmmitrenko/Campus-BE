using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Campus.Subject.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoLessonsNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonNumbers",
                keyColumn: "Number",
                keyValue: 6);
        }
    }
}
