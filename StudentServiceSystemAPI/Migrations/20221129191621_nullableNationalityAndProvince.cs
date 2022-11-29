using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class nullableNationalityAndProvince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 20, 12, 19, 510, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 20, 12, 19, 510, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 20, 12, 19, 510, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 26, 20, 12, 19, 510, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2089), new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2091), new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2092), new DateTime(2022, 11, 26, 19, 12, 19, 510, DateTimeKind.Utc).AddTicks(2092) });
        }
    }
}
