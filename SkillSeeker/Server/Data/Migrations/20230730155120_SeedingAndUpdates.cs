using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkillSeeker.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAndUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Capacity", "Category", "Description", "EndDate", "ImageUrl", "Instructor", "Location", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, 50, "Programming", "Learn the basics of programming with this introductory course.", new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5625), "https://via.placeholder.com/300", "John Smith", "Online", "Introduction to Programming", 99.99m, new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5570) },
                    { 2, 30, "Marketing", "Discover the world of digital marketing and its key concepts.", new DateTime(2023, 9, 3, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5631), "https://via.placeholder.com/300", "Emily Johnson", "Online", "Digital Marketing Fundamentals", 79.99m, new DateTime(2023, 8, 6, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5630) },
                    { 3, 20, "Photography", "Take stunning photos with this comprehensive photography course.", new DateTime(2023, 10, 1, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5635), "https://via.placeholder.com/300", "Michael Williams", "In-Person", "Photography Masterclass", 149.99m, new DateTime(2023, 8, 20, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5634) },
                    { 4, 40, "Finance", "Learn how to manage your finances and create a budget.", new DateTime(2023, 8, 27, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5639), "https://via.placeholder.com/300", "Sarah Lee", "Online", "Financial Planning and Budgeting", 89.99m, new DateTime(2023, 8, 9, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5638) },
                    { 5, 15, "Cooking", "Start your culinary journey with this cooking basics course.", new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5643), "https://via.placeholder.com/300", "Chef James", "In-Person", "Cooking Basics for Beginners", 129.99m, new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5641) },
                    { 6, 25, "Health", "Improve your fitness and well-being with this holistic course.", new DateTime(2023, 9, 3, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5646), "https://via.placeholder.com/300", "Emma Davis", "Online", "Fitness and Wellness", 69.99m, new DateTime(2023, 8, 6, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5645) },
                    { 7, 20, "Design", "Get started with graphic design and create stunning visuals.", new DateTime(2023, 10, 1, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5650), "https://via.placeholder.com/300", "David Taylor", "In-Person", "Graphic Design Essentials", 149.99m, new DateTime(2023, 8, 20, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5648) },
                    { 8, 30, "Writing", "Unleash your creativity and learn the art of writing fiction.", new DateTime(2023, 8, 27, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5653), "https://via.placeholder.com/300", "Olivia Roberts", "Online", "Writing Fiction: Creative Storytelling", 79.99m, new DateTime(2023, 8, 9, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5652) },
                    { 9, 25, "Communication", "Overcome your fear of public speaking and become a confident speaker.", new DateTime(2023, 9, 10, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5657), "https://via.placeholder.com/300", "Robert Anderson", "In-Person", "Public Speaking Mastery", 129.99m, new DateTime(2023, 8, 13, 17, 51, 20, 528, DateTimeKind.Local).AddTicks(5655) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Courses");
        }
    }
}
