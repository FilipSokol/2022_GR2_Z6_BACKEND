using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class changesinmodels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 4, 51, 730, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 4, 51, 730, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 4, 51, 730, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 4, 51, 730, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6095), new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6097), new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6098), new DateTime(2022, 10, 23, 14, 4, 51, 730, DateTimeKind.Utc).AddTicks(6098) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 23, 16, 2, 51, 976, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9361), new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9362), new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9363), new DateTime(2022, 10, 23, 14, 2, 51, 976, DateTimeKind.Utc).AddTicks(9363) });
        }
    }
}
