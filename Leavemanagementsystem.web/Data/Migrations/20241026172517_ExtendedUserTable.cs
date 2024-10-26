using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leavemanagementsystem.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b019ecee-37de-4e90-a460-2cc9a7591187", new DateOnly(1950, 12, 12), "Default", "Default", "AQAAAAIAAYagAAAAECXtOtMN5+D83qhxoA8pvAVOdHzk4a741MGYPmS88c5A7kuvirHTuyfpXwfZBB1Crg==", "b8dd5a14-9305-49fd-90b6-4173613407e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c66e08f-f3d5-4f25-ab4e-4d62d18664a2", "AQAAAAIAAYagAAAAENgUr1jYwCsvigBl9pMyAp9W7RNrxi8ZXXbx5l7Qb5jP51DzSZWtL8jx0KGy9WaRFQ==", "45e63457-fbb8-4d53-8f69-ea4a356a3a3b" });
        }
    }
}
