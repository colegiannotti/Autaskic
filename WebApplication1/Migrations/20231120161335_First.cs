using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PredictedEnergy = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AverageEnergy = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskBase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Energy = table.Column<int>(type: "INTEGER", nullable: false),
                    Enjoyment = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeSpan = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    LastCompletedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tolerance = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeOfDay = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    DayId = table.Column<int>(type: "INTEGER", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Skippable = table.Column<bool>(type: "INTEGER", nullable: true),
                    Period = table.Column<int>(type: "INTEGER", nullable: true),
                    Unit = table.Column<int>(type: "INTEGER", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskBase_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskBaseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_TaskBase_TaskBaseId",
                        column: x => x.TaskBaseId,
                        principalTable: "TaskBase",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TaskBase",
                columns: new[] { "Id", "DayId", "Description", "Discriminator", "Energy", "Enjoyment", "LastCompletedDate", "Name", "Priority", "Skippable", "TimeOfDay", "TimeSpan", "Tolerance" },
                values: new object[] { 1, null, "Example Description", "TaskDaily", 5, 5, new DateTime(2023, 11, 20, 11, 13, 35, 400, DateTimeKind.Local).AddTicks(6211), "Example Daily Task", 1, true, new TimeOnly(8, 0, 0), new TimeSpan(0, 0, 30, 0, 0), 5 });

            migrationBuilder.InsertData(
                table: "TaskBase",
                columns: new[] { "Id", "DayId", "Description", "Discriminator", "Energy", "Enjoyment", "LastCompletedDate", "Name", "Period", "Priority", "TimeOfDay", "TimeSpan", "Tolerance", "Unit" },
                values: new object[] { 2, null, "Example Description", "TaskPeriodic", 5, 5, new DateTime(2023, 11, 20, 11, 13, 35, 413, DateTimeKind.Local).AddTicks(9396), "Example Periodic Task", 1, 1, new TimeOnly(8, 0, 0), new TimeSpan(0, 0, 30, 0, 0), 5, 3 });

            migrationBuilder.InsertData(
                table: "TaskBase",
                columns: new[] { "Id", "DayId", "Description", "Discriminator", "DueDate", "Energy", "Enjoyment", "LastCompletedDate", "Name", "Priority", "TimeOfDay", "TimeSpan", "Tolerance" },
                values: new object[] { 3, null, "Example Description", "TaskTransient", new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(40), 5, 5, new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(19), "Example Transient Task", 1, new TimeOnly(8, 0, 0), new TimeSpan(0, 0, 30, 0, 0), 5 });

            migrationBuilder.InsertData(
                table: "TaskBase",
                columns: new[] { "Id", "DayId", "Description", "Discriminator", "Energy", "Enjoyment", "LastCompletedDate", "Name", "Priority", "TimeOfDay", "TimeSpan", "Tolerance" },
                values: new object[] { 4, null, "Example Description", "TaskTransition", 5, 5, new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(435), "Example Periodic Task", 1, new TimeOnly(8, 0, 0), new TimeSpan(0, 0, 30, 0, 0), 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Steps_TaskBaseId",
                table: "Steps",
                column: "TaskBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskBase_DayId",
                table: "TaskBase",
                column: "DayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "TaskBase");

            migrationBuilder.DropTable(
                name: "Days");
        }
    }
}
