using AppStoreBackend.Models;
using System.Linq;

namespace AppStoreBackend.Data.Seeders
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Check if there are any categories, if not, seed them
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryID = 1, CategoryName = "Productivity", IconPath = "icons/productivity.png" },
                    new Category { CategoryID = 2, CategoryName = "Games", IconPath = "icons/games.png" }
                );
            }

            // Check if there are any apps, if not, seed them
            if (!context.Apps.Any())
            {
                context.Apps.AddRange(
                    new App { AppID = 1, Name = "ToDo App", Description = "Task management app", Price = 0.0m, IsPopular = true, CategoryID = 1 },
                    new App { AppID = 2, Name = "Space Invaders", Description = "Classic arcade game", Price = 4.99m, IsPopular = false, CategoryID = 2 }
                );
            }

            // Check if there are any users, if not, seed them
            if (!context.Users.Any())
            {
                context.Users.Add(
                    new User { UserID = 1, Username = "testuser", Email = "testuser@example.com", Password = "password123" }
                );
            }

            // Save changes to apply the seeds
            context.SaveChanges();
        }
    }
}
