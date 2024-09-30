using AppStoreBackend.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AppStoreBackend.Data.Seeders
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Id = 1, CategoryName = "Games", IconPath = "games.png" },
                    new Category { Id = 2, CategoryName = "Productivity", IconPath = "productivity.png" }
                );
                context.SaveChanges();
            }

            if (!context.Apps.Any())
            {
                // Note that CategoryId must match the correct property name in the App model
                context.Apps.AddRange(
                    new App { Name = "Game One", Description = "An exciting game.", Price = 4.99m, CategoryId = 1 },
                    new App { Name = "Productivity App", Description = "Boost your productivity.", Price = 9.99m, CategoryId = 2 }
                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@appstore.com",
                    Password = "password"
                });
                context.SaveChanges();
            }
        }
    }
}
