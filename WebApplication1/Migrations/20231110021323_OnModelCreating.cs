using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Costs",
                columns: new[] { "Id", "Energy", "Enjoyment", "TimeSpan" },
                values: new object[] { 1, 10, 5, new TimeSpan(0, 0, 0, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Costs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
