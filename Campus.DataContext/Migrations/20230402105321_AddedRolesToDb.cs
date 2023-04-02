using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Campus.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d8ddbd54-1ab5-482b-936a-e38f8665a4f9", "9ad4cf59-4f13-4b4e-a668-29d6f6b4e2c2", "Admin", "ADMIN" },
                    { "dc6e8162-5a19-4921-9bc1-930db7130796", "783d665f-efcd-45ac-a607-8d4f1924a033", "Educator", "EDUCATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8ddbd54-1ab5-482b-936a-e38f8665a4f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc6e8162-5a19-4921-9bc1-930db7130796");
        }
    }
}
