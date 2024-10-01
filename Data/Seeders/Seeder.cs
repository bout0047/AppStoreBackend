using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AppStoreBackend.Data.Seeders
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        CategoryName = "Games",
                        IconPath = "path/to/games/icon.png",
                    },
                    new Category
                    {
                        CategoryName = "Productivity",
                        IconPath = "path/to/productivity/icon.png",
                    }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Apps.Any())
            {
                var apps = new List<App>
                {
                    new App
                    {
                        Name = "Game One",
                        Description = "An exciting game.",
                        Category = context.Categories.First(c => c.CategoryName == "Games")
                    },
                    new App
                    {
                        Name = "Productivity App",
                        Description = "Boost your productivity.",
                        Category = context.Categories.First(c => c.CategoryName == "Productivity")
                    }
                };
                context.Apps.AddRange(apps);
                context.SaveChanges();
            }

            if (!context.Purchases.Any())
            {
                var user = context.Users.FirstOrDefault();
                var app = context.Apps.FirstOrDefault();

                var purchases = new List<Purchase>
                {
                    new Purchase
                    {
                        User = user,
                        App = app
                    },
                    new Purchase
                    {
                        User = user,
                        App = app
                    }
                };
                context.Purchases.AddRange(purchases);
                context.SaveChanges();
            }
        }
    }
}
