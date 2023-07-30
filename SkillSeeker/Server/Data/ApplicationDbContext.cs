using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SkillSeeker.Server.Models;
using SkillSeeker.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillSeeker.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);          

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Introduction to Programming",
                    Description = "Learn the basics of programming with this introductory course.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Programming",
                    Location = "Online",
                    StartDate = DateTime.Now.AddDays(14),
                    EndDate = DateTime.Now.AddDays(42),
                    Capacity = 50,
                    Price = 99.99m,
                    Instructor = "John Smith"
                },
                new Course
                {
                    Id = 2,
                    Name = "Digital Marketing Fundamentals",
                    Description = "Discover the world of digital marketing and its key concepts.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Marketing",
                    Location = "Online",
                    StartDate = DateTime.Now.AddDays(7),
                    EndDate = DateTime.Now.AddDays(35),
                    Capacity = 30,
                    Price = 79.99m,
                    Instructor = "Emily Johnson"
                },
                new Course
                {
                    Id = 3,
                    Name = "Photography Masterclass",
                    Description = "Take stunning photos with this comprehensive photography course.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Photography",
                    Location = "In-Person",
                    StartDate = DateTime.Now.AddDays(21),
                    EndDate = DateTime.Now.AddDays(63),
                    Capacity = 20,
                    Price = 149.99m,
                    Instructor = "Michael Williams"
                },
                new Course
                {
                    Id = 4,
                    Name = "Financial Planning and Budgeting",
                    Description = "Learn how to manage your finances and create a budget.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Finance",
                    Location = "Online",
                    StartDate = DateTime.Now.AddDays(10),
                    EndDate = DateTime.Now.AddDays(28),
                    Capacity = 40,
                    Price = 89.99m,
                    Instructor = "Sarah Lee"
                },
                new Course
                {
                    Id = 5,
                    Name = "Cooking Basics for Beginners",
                    Description = "Start your culinary journey with this cooking basics course.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Cooking",
                    Location = "In-Person",
                    StartDate = DateTime.Now.AddDays(14),
                    EndDate = DateTime.Now.AddDays(42),
                    Capacity = 15,
                    Price = 129.99m,
                    Instructor = "Chef James"
                },
                new Course
                {
                    Id = 6,
                    Name = "Fitness and Wellness",
                    Description = "Improve your fitness and well-being with this holistic course.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Health",
                    Location = "Online",
                    StartDate = DateTime.Now.AddDays(7),
                    EndDate = DateTime.Now.AddDays(35),
                    Capacity = 25,
                    Price = 69.99m,
                    Instructor = "Emma Davis"
                },
                new Course
                {
                    Id = 7,
                    Name = "Graphic Design Essentials",
                    Description = "Get started with graphic design and create stunning visuals.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Design",
                    Location = "In-Person",
                    StartDate = DateTime.Now.AddDays(21),
                    EndDate = DateTime.Now.AddDays(63),
                    Capacity = 20,
                    Price = 149.99m,
                    Instructor = "David Taylor"
                },
                new Course
                {
                    Id = 8,
                    Name = "Writing Fiction: Creative Storytelling",
                    Description = "Unleash your creativity and learn the art of writing fiction.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Writing",
                    Location = "Online",
                    StartDate = DateTime.Now.AddDays(10),
                    EndDate = DateTime.Now.AddDays(28),
                    Capacity = 30,
                    Price = 79.99m,
                    Instructor = "Olivia Roberts"
                },
                new Course
                {
                    Id = 9,
                    Name = "Public Speaking Mastery",
                    Description = "Overcome your fear of public speaking and become a confident speaker.",
                    ImageUrl = "https://via.placeholder.com/300",
                    Category = "Communication",
                    Location = "In-Person",
                    StartDate = DateTime.Now.AddDays(14),
                    EndDate = DateTime.Now.AddDays(42),
                    Capacity = 25,
                    Price = 129.99m,
                    Instructor = "Robert Anderson"
                }
            );
        }
    }
}
