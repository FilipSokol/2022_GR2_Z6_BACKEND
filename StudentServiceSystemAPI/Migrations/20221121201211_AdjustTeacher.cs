using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class AdjustTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Teachers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teachers",
                newName: "FirstName");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 21, 12, 11, 172, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 21, 12, 11, 172, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 21, 12, 11, 172, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 21, 12, 11, 172, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8693), new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8695), new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8696), new DateTime(2022, 11, 21, 20, 12, 11, 172, DateTimeKind.Utc).AddTicks(8696) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teachers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teachers",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 18, 27, 2, 680, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 18, 27, 2, 680, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 18, 27, 2, 680, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 18, 27, 2, 680, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5713), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5714), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5715), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5715) });
        }
    }
}
