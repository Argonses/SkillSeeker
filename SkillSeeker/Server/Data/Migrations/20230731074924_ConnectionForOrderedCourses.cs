using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillSeeker.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConnectionForOrderedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderedCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedCourses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 11, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6689), new DateTime(2023, 8, 14, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6695), new DateTime(2023, 8, 7, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 2, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 8, 21, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 28, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6703), new DateTime(2023, 8, 10, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 11, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6707), new DateTime(2023, 8, 14, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 8, 7, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 2, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 8, 21, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 28, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 8, 10, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 11, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6721), new DateTime(2023, 8, 14, 9, 49, 24, 647, DateTimeKind.Local).AddTicks(6720) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderedCourses");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2309) });
        }
    }
}
