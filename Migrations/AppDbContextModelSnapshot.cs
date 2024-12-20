﻿// <auto-generated />
using System;
using AppStoreBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppStoreBackend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppStoreBackend.Models.App", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Apps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "An amazing game that is fun to play!",
                            Name = "Super Fun Game"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Boost your productivity with this organizer app.",
                            Name = "Work Organizer"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "An educational app for learning Spanish.",
                            Name = "Learn Spanish"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Description = "Track your fitness and health goals.",
                            Name = "FitLife"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "An app for finding and streaming movies.",
                            Name = "Movie Night"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "A challenging word game to test your vocabulary.",
                            Name = "Word Quest"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Organize your day with ease.",
                            Name = "Daily Planner"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Learn and master mathematics with engaging lessons.",
                            Name = "Math Genius"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Description = "Practice yoga and stay healthy.",
                            Name = "Yoga for All"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Description = "Stream your favorite songs anytime.",
                            Name = "Music Streamer"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "Become a hero in this action-packed game.",
                            Name = "Battle Heroes"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "A productivity app to manage team projects.",
                            Name = "Team Collaborator"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Learn amazing facts about science.",
                            Name = "Science Facts"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "Track your daily calorie intake easily.",
                            Name = "Calorie Counter"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Challenge yourself with fun trivia questions.",
                            Name = "Trivia Master"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 1,
                            Description = "A thrilling racing game with amazing graphics.",
                            Name = "Racing Frenzy"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "Guided meditation sessions for relaxation.",
                            Name = "Mindful Meditation"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Learn multiple languages with interactive lessons.",
                            Name = "Language Hub"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            Description = "Manage your expenses and save more.",
                            Name = "Budget Tracker"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Watch funny videos and stand-up comedy.",
                            Name = "Comedy Central"
                        });
                });

            modelBuilder.Entity("AppStoreBackend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "All fun games",
                            IconPath = "path/to/games/icon.png",
                            Name = "Games"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Boost your productivity",
                            IconPath = "path/to/productivity/icon.png",
                            Name = "Productivity"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Learn something new",
                            IconPath = "path/to/education/icon.png",
                            Name = "Education"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Entertainment and leisure apps",
                            IconPath = "path/to/entertainment/icon.png",
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Health and fitness apps",
                            IconPath = "path/to/health/icon.png",
                            Name = "Health"
                        });
                });

            modelBuilder.Entity("AppStoreBackend.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("AppStoreBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppStoreBackend.Models.App", b =>
                {
                    b.HasOne("AppStoreBackend.Models.Category", "Category")
                        .WithMany("Apps")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AppStoreBackend.Models.Purchase", b =>
                {
                    b.HasOne("AppStoreBackend.Models.App", "App")
                        .WithMany("Purchases")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppStoreBackend.Models.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("App");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppStoreBackend.Models.App", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("AppStoreBackend.Models.Category", b =>
                {
                    b.Navigation("Apps");
                });

            modelBuilder.Entity("AppStoreBackend.Models.User", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
