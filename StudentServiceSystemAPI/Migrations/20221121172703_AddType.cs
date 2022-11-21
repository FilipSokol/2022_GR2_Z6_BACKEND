using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class AddType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "EndTime", "StartTime", "Type" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5713), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5711), 3 });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime", "Type" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5714), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5714), 3 });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime", "Type" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5715), new DateTime(2022, 11, 21, 17, 27, 2, 680, DateTimeKind.Utc).AddTicks(5715), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 31, 19, 50, 51, 159, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 31, 19, 50, 51, 159, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 31, 19, 50, 51, 159, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 10, 31, 19, 50, 51, 159, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2684), new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2686), new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2687), new DateTime(2022, 10, 31, 18, 50, 51, 159, DateTimeKind.Utc).AddTicks(2687) });
        }
    }
}
