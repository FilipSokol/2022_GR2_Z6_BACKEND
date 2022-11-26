using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class AddScheduleIdToSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 59, 26, 927, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 59, 26, 927, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 59, 26, 927, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 18, 59, 26, 927, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2755), 1, new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2808), 1, new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2810), 1, new DateTime(2022, 11, 26, 17, 59, 26, 927, DateTimeKind.Utc).AddTicks(2809) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8065), null, new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8067), null, new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8069), null, new DateTime(2022, 11, 26, 17, 55, 1, 213, DateTimeKind.Utc).AddTicks(8068) });
        }
    }
}
