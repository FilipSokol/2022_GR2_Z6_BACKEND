using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class nullableProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 30, 18, 35, 8, 816, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(243), new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(244), new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(245), new DateTime(2022, 11, 30, 17, 35, 8, 816, DateTimeKind.Utc).AddTicks(245) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 29, 20, 16, 21, 38, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 29, 20, 16, 21, 38, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 29, 20, 16, 21, 38, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 29, 20, 16, 21, 38, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6057), new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6059), new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6060), new DateTime(2022, 11, 29, 19, 16, 21, 38, DateTimeKind.Utc).AddTicks(6059) });
        }
    }
}
