using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class changesinmodels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Groups_GroupId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Schedule_ScheduleId",
                table: "WeekDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_GroupId",
                table: "Schedules",
                newName: "IX_Schedules_GroupId");

            migrationBuilder.AlterColumn<int>(
                name: "WeekDaysId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "GroupId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Email", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "kowalski@teacher.com", "Jan", "Kowalski" },
                    { 2, "nowak@teacher.com", "Adam", "Nowak" },
                    { 3, "monitor@teacher.com", "Michał", "Monitor" }
                });

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

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Description", "ECTS", "EndTime", "Name", "StartTime", "TeacherId", "WeekDaysId" },
                values: new object[] { 1, "Biology subject", 0, new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9361), "Biology", new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9359), 1, 1 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Description", "ECTS", "EndTime", "Name", "StartTime", "TeacherId", "WeekDaysId" },
                values: new object[] { 2, "Math subject", 0, new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9362), "Math", new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9362), 2, 1 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Description", "ECTS", "EndTime", "Name", "StartTime", "TeacherId", "WeekDaysId" },
                values: new object[] { 3, "Computer Science subject", 0, new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9363), "Computer Science", new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9363), 3, 1 });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "MarkId", "DateOfIssue", "Description", "MarkValue", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9385), "desc", 5.0, 1, 1 },
                    { 2, new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9418), "desc", 4.0, 2, 2 },
                    { 3, new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9420), "desc", 3.0, 1, 2 },
                    { 4, new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9422), "desc", 4.0, 3, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Groups_GroupId",
                table: "Schedules",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects",
                column: "WeekDaysId",
                principalTable: "WeekDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Schedules_ScheduleId",
                table: "WeekDays",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Groups_GroupId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Schedules_ScheduleId",
                table: "WeekDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_GroupId",
                table: "Schedule",
                newName: "IX_Schedule_GroupId");

            migrationBuilder.AlterColumn<int>(
                name: "WeekDaysId",
                table: "Subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Groups_GroupId",
                table: "Schedule",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_WeekDays_WeekDaysId",
                table: "Subjects",
                column: "WeekDaysId",
                principalTable: "WeekDays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Schedule_ScheduleId",
                table: "WeekDays",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
