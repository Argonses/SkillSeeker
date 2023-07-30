﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillSeeker.Server.Data;

#nullable disable

namespace SkillSeeker.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230730161613_UpdateSeeding")]
    partial class UpdateSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SkillSeeker.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SkillSeeker.Shared.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            Category = "Programming",
                            Description = "Learn the basics of programming with this introductory course.",
                            EndDate = new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2278),
                            ImageUrl = "https://www.cdcs.ed.ac.uk/files/inline-images/PythonBeginner_0.png",
                            Instructor = "John Smith",
                            Location = "Online",
                            Name = "Introduction to Programming",
                            Price = 99.99m,
                            StartDate = new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2226)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 30,
                            Category = "Marketing",
                            Description = "Discover the world of digital marketing and its key concepts.",
                            EndDate = new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2284),
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1Wt5uGXJhQJkKGLpgiwp7NFyMB7mE5snctSC6JAnF0xHvvRR2iA34-KsoO-qKV4cWdgg&usqp=CAU",
                            Instructor = "Emily Johnson",
                            Location = "Online",
                            Name = "Digital Marketing Fundamentals",
                            Price = 79.99m,
                            StartDate = new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2283)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 20,
                            Category = "Photography",
                            Description = "Take stunning photos with this comprehensive photography course.",
                            EndDate = new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2288),
                            ImageUrl = "https://swathysivakumaar.com/wp-content/uploads/2020/10/CC_Express_20220112_1325250.6560828388678402-500x330.png",
                            Instructor = "Michael Williams",
                            Location = "In-Person",
                            Name = "Photography Masterclass",
                            Price = 149.99m,
                            StartDate = new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2287)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 40,
                            Category = "Finance",
                            Description = "Learn how to manage your finances and create a budget.",
                            EndDate = new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2292),
                            ImageUrl = "https://reba.global/static/b830122557964a9f3b18b08bec8971a2/B830-1547291916SupportemployeeswithfinancialskillsMAIN.jpg",
                            Instructor = "Sarah Lee",
                            Location = "Online",
                            Name = "Financial Planning and Budgeting",
                            Price = 89.99m,
                            StartDate = new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2290)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 15,
                            Category = "Cooking",
                            Description = "Start your culinary journey with this cooking basics course.",
                            EndDate = new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2295),
                            ImageUrl = "https://www.dummies.com/wp-content/uploads/CookingBasics-586x586.png",
                            Instructor = "Chef James",
                            Location = "In-Person",
                            Name = "Cooking Basics for Beginners",
                            Price = 129.99m,
                            StartDate = new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2294)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 25,
                            Category = "Health",
                            Description = "Improve your fitness and well-being with this holistic course.",
                            EndDate = new DateTime(2023, 9, 3, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2299),
                            ImageUrl = "https://www.pegs.com/wp-content/uploads/2017/02/fitness-wellness-trends-for-hotels.jpg",
                            Instructor = "Emma Davis",
                            Location = "Online",
                            Name = "Fitness and Wellness",
                            Price = 69.99m,
                            StartDate = new DateTime(2023, 8, 6, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2298)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 20,
                            Category = "Design",
                            Description = "Get started with graphic design and create stunning visuals.",
                            EndDate = new DateTime(2023, 10, 1, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2303),
                            ImageUrl = "https://www.goskills.com/blobs/blogs/209/4.jpg",
                            Instructor = "David Taylor",
                            Location = "In-Person",
                            Name = "Graphic Design Essentials",
                            Price = 149.99m,
                            StartDate = new DateTime(2023, 8, 20, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2302)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 30,
                            Category = "Writing",
                            Description = "Unleash your creativity and learn the art of writing fiction.",
                            EndDate = new DateTime(2023, 8, 27, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2307),
                            ImageUrl = "https://i0.wp.com/learningenglishwithoxford.com/wp-content/uploads/2022/09/LEWO-Blog-creative-writing-1.png?fit=1600%2C900&ssl=1",
                            Instructor = "Olivia Roberts",
                            Location = "Online",
                            Name = "Writing Fiction: Creative Storytelling",
                            Price = 79.99m,
                            StartDate = new DateTime(2023, 8, 9, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2306)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 25,
                            Category = "Communication",
                            Description = "Overcome your fear of public speaking and become a confident speaker.",
                            EndDate = new DateTime(2023, 9, 10, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2310),
                            ImageUrl = "https://speakingcpr.com/wp-content/uploads/Public-Speaking-scaled.jpg",
                            Instructor = "Robert Anderson",
                            Location = "In-Person",
                            Name = "Public Speaking Mastery",
                            Price = 129.99m,
                            StartDate = new DateTime(2023, 8, 13, 18, 16, 13, 696, DateTimeKind.Local).AddTicks(2309)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SkillSeeker.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SkillSeeker.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillSeeker.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SkillSeeker.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
