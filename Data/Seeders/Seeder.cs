using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Seeders
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Check if there are any categories, users, etc., and seed them if none exist
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryName = "Games", IconPath = "/icons/games.png" },
                    new Category { CategoryName = "Productivity", IconPath = "/icons/productivity.png" }
                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Username = "admin", Email = "admin@appstore.com", Password = "admin123" },
                    new User { Username = "user1", Email = "user1@appstore.com", Password = "password" }
                );
                context.SaveChanges();
            }
        }
    }
}

