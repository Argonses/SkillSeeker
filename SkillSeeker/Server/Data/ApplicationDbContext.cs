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
                    ImageUrl = "https://www.cdcs.ed.ac.uk/files/inline-images/PythonBeginner_0.png",
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
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1Wt5uGXJhQJkKGLpgiwp7NFyMB7mE5snctSC6JAnF0xHvvRR2iA34-KsoO-qKV4cWdgg&usqp=CAU",
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
                    ImageUrl = "https://swathysivakumaar.com/wp-content/uploads/2020/10/CC_Express_20220112_1325250.6560828388678402-500x330.png",
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
                    ImageUrl = "https://reba.global/static/b830122557964a9f3b18b08bec8971a2/B830-1547291916SupportemployeeswithfinancialskillsMAIN.jpg",
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
                    ImageUrl = "https://www.dummies.com/wp-content/uploads/CookingBasics-586x586.png",
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
                    ImageUrl = "https://www.pegs.com/wp-content/uploads/2017/02/fitness-wellness-trends-for-hotels.jpg",
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
                    ImageUrl = "https://www.goskills.com/blobs/blogs/209/4.jpg",
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
                    ImageUrl = "https://i0.wp.com/learningenglishwithoxford.com/wp-content/uploads/2022/09/LEWO-Blog-creative-writing-1.png?fit=1600%2C900&ssl=1",
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
                    ImageUrl = "https://speakingcpr.com/wp-content/uploads/Public-Speaking-scaled.jpg",
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
