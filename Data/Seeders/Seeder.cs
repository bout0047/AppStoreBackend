using AppStoreBackend.Data;
using AppStoreBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Seeder
{
    public static void Seed(AppDbContext context)
    {
        Console.WriteLine("Starting database seeding...");

        // Seed Categories
        if (!context.Categories.Any())
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryName = "Games",
                    IconPath = "path/to/games-icon.png"
                },
                new Category
                {
                    CategoryName = "Productivity",
                    IconPath = "path/to/productivity-icon.png"
                }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
            Console.WriteLine("Seeded Categories.");
        }

        // Seed Apps
        if (!context.Apps.Any())
        {
            var categories = context.Categories.ToList();
            if (categories.Count >= 2)
            {
                var apps = new List<App>
                {
                    new App
                    {
                        Name = "Game One",
                        Description = "An exciting game.",
                        Category = categories[0] // Set category to Games
                    },
                    new App
                    {
                        Name = "Productivity App",
                        Description = "Boost your productivity.",
                        Category = categories[1] // Set category to Productivity
                    }
                };

                context.Apps.AddRange(apps);
                context.SaveChanges();
                Console.WriteLine("Seeded Apps.");
            }
            else
            {
                Console.WriteLine("Categories not seeded properly. Skipping Apps seeding.");
            }
        }

        // Seed Users
        if (!context.Users.Any())
        {
            var users = new List<User>
            {
                new User
                {
                    Username = "user1",
                    Password = "password1",
                    Email = "user1@example.com"
                },
                new User
                {
                    Username = "user2",
                    Password = "password2",
                    Email = "user2@example.com"
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
            Console.WriteLine("Seeded Users.");
        }

        // Seed Purchases
        if (!context.Purchases.Any())
        {
            var users = context.Users.ToList();
            var apps = context.Apps.ToList();

            if (users.Count >= 2 && apps.Count >= 2)
            {
                var purchases = new List<Purchase>
                {
                    new Purchase
                    {
                        User = users[0],
                        App = apps[0]
                    },
                    new Purchase
                    {
                        User = users[1],
                        App = apps[1]
                    }
                };

                context.Purchases.AddRange(purchases);
                context.SaveChanges();
                Console.WriteLine("Seeded Purchases.");
            }
            else
            {
                Console.WriteLine("Users or Apps not seeded properly. Skipping Purchases seeding.");
            }
        }

        Console.WriteLine("Database seeding completed.");
    }
}
