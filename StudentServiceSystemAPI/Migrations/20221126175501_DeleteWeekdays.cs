using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class DeleteWeekdays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_WeekDaysId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "WeekDaysId",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 55, 1, 213, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 55, 1, 213, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 55, 1, 213, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 55, 1, 213, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8065), new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8067), new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8069), new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ScheduleId",
                table: "Subjects",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Schedules_ScheduleId",
                table: "Subjects",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Schedules_ScheduleId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ScheduleId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "WeekDaysId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeekDays_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 12, 18, 642, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 12, 18, 642, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 12, 18, 642, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 12, 18, 642, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "Id", "Name", "ScheduleId" },
                values: new object[,]
                {
                    { 1, "Monday", 1 },
                    { 2, "Tuesday", 1 },
                    { 3, "Wednesday", 1 },
                    { 4, "Thursday", 1 },
                    { 5, "Friday", 1 },
                    { 6, "Saturday", 1 },
                    { 7, "Sunday", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime", "WeekDaysId" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2574), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2570), 1 });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime", "WeekDaysId" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2578), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2576), 1 });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime", "WeekDaysId" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2581), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2580), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_WeekDaysId",
                table: "Subjects",
                column: "WeekDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_ScheduleId",
                table: "WeekDays",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects",
                column: "WeekDaysId",
                principalTable: "WeekDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
