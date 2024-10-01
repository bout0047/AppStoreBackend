using System;
using System.Linq;
using AppStoreBackend.Models;
using AppStoreBackend.Data;

namespace AppStoreBackend.Data.Seeders
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Check if any categories already exist; if not, seed data
            if (!context.Categories.Any())
            {
                var categories = new[]
                {
                    new Category { CategoryName = "Games", IconPath = "icons/games.png" },
                    new Category { CategoryName = "Productivity", IconPath = "icons/productivity.png" },
                    new Category { CategoryName = "Education", IconPath = "icons/education.png" }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            // Check if any apps already exist; if not, seed data
            if (!context.Apps.Any())
            {
                var gamesCategory = context.Categories.FirstOrDefault(c => c.CategoryName == "Games");
                var productivityCategory = context.Categories.FirstOrDefault(c => c.CategoryName == "Productivity");

                if (gamesCategory != null && productivityCategory != null)
                {
                    var apps = new[]
                    {
                        new App { Name = "Space Invaders", Description = "A classic arcade game.", Price = 4.99M, CategoryId = gamesCategory.Id },
                        new App { Name = "Task Master", Description = "Productivity app to organize tasks.", Price = 9.99M, CategoryId = productivityCategory.Id }
                    };

                    context.Apps.AddRange(apps);
                    context.SaveChanges();
                }
            }

            // Check if users already exist; if not, seed data
            if (!context.Users.Any())
            {
                var users = new[]
                {
                    new User { Username = "JohnDoe", Email = "john@example.com", Password = "password123" },
                    new User { Username = "JaneDoe", Email = "jane@example.com", Password = "password456" }
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            // Check if purchases already exist; if not, seed data
            if (!context.Purchases.Any())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == "JohnDoe");
                var app = context.Apps.FirstOrDefault(a => a.Name == "Space Invaders");

                if (user != null && app != null)
                {
                    var purchases = new[]
                    {
                        new Purchase { PurchaseDate = DateTime.Now, Price = app.Price, UserId = user.Id, AppId = app.Id }
                    };

                    context.Purchases.AddRange(purchases);
                    context.SaveChanges();
                }
            }
        }
    }
}
