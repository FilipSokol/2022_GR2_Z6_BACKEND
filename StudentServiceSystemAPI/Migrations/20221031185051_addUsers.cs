using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceSystemAPI.Migrations
{
    public partial class addUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Marks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
