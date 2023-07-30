using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillSeeker.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2278), "https://www.cdcs.ed.ac.uk/files/inline-images/PythonBeginner_0.png", new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2284), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1Wt5uGXJhQJkKGLpgiwp7NFyMB7mE5snctSC6JAnF0xHvvRR2iA34-KsoO-qKV4cWdgg&usqp=CAU", new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2288), "https://swathysivakumaar.com/wp-content/uploads/2020/10/CC_Express_20220112_1325250.6560828388678402-500x330.png", new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2292), "https://reba.global/static/b830122557964a9f3b18b08bec8971a2/B830-1547291916SupportemployeeswithfinancialskillsMAIN.jpg", new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2295), "https://www.dummies.com/wp-content/uploads/CookingBasics-586x586.png", new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2299), "https://www.pegs.com/wp-content/uploads/2017/02/fitness-wellness-trends-for-hotels.jpg", new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2303), "https://www.goskills.com/blobs/blogs/209/4.jpg", new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2307), "https://i0.wp.com/learningenglishwithoxford.com/wp-content/uploads/2022/09/LEWO-Blog-creative-writing-1.png?fit=1600%2C900&ssl=1", new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2310), "https://speakingcpr.com/wp-content/uploads/Public-Speaking-scaled.jpg", new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2309) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5625), "https://via.placeholder.com/300", new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5631), "https://via.placeholder.com/300", new DateTime(2023, 8, 6, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5635), "https://via.placeholder.com/300", new DateTime(2023, 8, 20, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5639), "https://via.placeholder.com/300", new DateTime(2023, 8, 9, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5643), "https://via.placeholder.com/300", new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5646), "https://via.placeholder.com/300", new DateTime(2023, 8, 6, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5650), "https://via.placeholder.com/300", new DateTime(2023, 8, 20, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 27, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5653), "https://via.placeholder.com/300", new DateTime(2023, 8, 9, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "ImageUrl", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5657), "https://via.placeholder.com/300", new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5655) });
        }
    }
}
