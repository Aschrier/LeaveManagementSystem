using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leavemanagementsystem.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0468fec4-147c-45b6-82ea-8b409ff9734e", null, "Employee", "EMPLOYEE" },
                    { "e60f0db2-195c-492b-91ff-d700f7e7b057", null, "Superisor", "SUPERVISOR" },
                    { "e9f639de-624f-4a4e-b8bf-2381725462f1", null, "Administrator", "ADMINISTARTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "408aa945-3d84-4421-8342-7269ec64d949", 0, "2c66e08f-f3d5-4f25-ab4e-4d62d18664a2", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENgUr1jYwCsvigBl9pMyAp9W7RNrxi8ZXXbx5l7Qb5jP51DzSZWtL8jx0KGy9WaRFQ==", null, false, "45e63457-fbb8-4d53-8f69-ea4a356a3a3b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9f639de-624f-4a4e-b8bf-2381725462f1", "408aa945-3d84-4421-8342-7269ec64d949" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0468fec4-147c-45b6-82ea-8b409ff9734e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e60f0db2-195c-492b-91ff-d700f7e7b057");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9f639de-624f-4a4e-b8bf-2381725462f1", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9f639de-624f-4a4e-b8bf-2381725462f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949");
        }
    }
}
