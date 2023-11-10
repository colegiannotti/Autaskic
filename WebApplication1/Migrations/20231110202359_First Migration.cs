using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSpan = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Energy = table.Column<int>(type: "INTEGER", nullable: false),
                    Enjoyment = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CostModelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    LastCompletedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tolerance = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeOfDay = table.Column<TimeOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Costs_CostModelId",
                        column: x => x.CostModelId,
                        principalTable: "Costs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_Tasks_TaskModelId",
                        column: x => x.TaskModelId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Costs",
                columns: new[] { "Id", "Energy", "Enjoyment", "TimeSpan" },
                values: new object[,]
                {
                    { 1, 6, 9, new TimeSpan(0, 0, 15, 0, 0) },
                    { 2, 10, 8, new TimeSpan(0, 0, 15, 0, 0) },
                    { 3, 1, 9, new TimeSpan(0, 0, 50, 0, 0) },
                    { 4, 1, 8, new TimeSpan(0, 0, 15, 0, 0) },
                    { 5, 2, 2, new TimeSpan(0, 0, 45, 0, 0) },
                    { 6, 8, 8, new TimeSpan(0, 0, 30, 0, 0) },
                    { 7, 4, 8, new TimeSpan(0, 0, 50, 0, 0) },
                    { 8, 6, 6, new TimeSpan(0, 0, 30, 0, 0) },
                    { 9, 10, 6, new TimeSpan(0, 1, 0, 0, 0) },
                    { 10, 3, 2, new TimeSpan(0, 0, 25, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CostModelId", "Description", "LastCompletedDate", "Name", "Priority", "TimeOfDay", "Tolerance" },
                values: new object[] { 1, 1, "Example Description", new DateTime(2023, 11, 10, 15, 23, 59, 1, DateTimeKind.Local).AddTicks(2493), "Example Task", 7, new TimeOnly(8, 0, 0), 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Steps_TaskModelId",
                table: "Steps",
                column: "TaskModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CostModelId",
                table: "Tasks",
                column: "CostModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Costs");
        }
    }
}
