using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesShare.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdminDateUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateOnly(2024, 4, 8));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateOnly(2024, 4, 8));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateOnly(2024, 4, 8));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateOnly(1, 1, 1));
        }
    }
}
