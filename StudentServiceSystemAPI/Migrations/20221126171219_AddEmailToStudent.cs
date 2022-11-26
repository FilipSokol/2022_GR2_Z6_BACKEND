using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class AddEmailToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "Email",
                value: "jan@kowalski.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "Email",
                value: "adam@nowak.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "Email",
                value: "arek@kedziora.com");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2574), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2578), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2581), new DateTime(2022, 11, 26, 17, 12, 18, 642, DateTimeKind.Utc).AddTicks(2580) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 22, 16, 6, 908, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 22, 16, 6, 908, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 22, 16, 6, 908, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4,
                column: "DateOfIssue",
                value: new DateTime(2022, 11, 21, 22, 16, 6, 908, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8501), new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8502), new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8503), new DateTime(2022, 11, 21, 21, 16, 6, 908, DateTimeKind.Utc).AddTicks(8503) });
        }
    }
}
