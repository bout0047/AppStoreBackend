using AppStoreBackend.Models;
using System.Linq;

namespace AppStoreBackend.Data
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Seed Users
            if (!context.Users.Any())
            {
                context.Users.AddRange(new[]
                {
                    new User { Username = "User1", Password = "password1", Email = "user1@example.com" },
                    new User { Username = "User2", Password = "password2", Email = "user2@example.com" }
                });
            }

            // Seed Categories
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(new[]
                {
                    new Category { Name = "Games", Description = "All kinds of games" },
                    new Category { Name = "Music", Description = "Music apps and tools" }
                });
            }

            // Seed Apps
            if (!context.Apps.Any())
            {
                context.Apps.AddRange(new[]
                {
                    new App { Id = 1, Name = "Sample App 1", Description = "This is a sample app", Rating = 4.5, CategoryId = 1, Price = 9.99m },
                    new App { Id = 2, Name = "Sample App 2", Description = "This is another sample app", Rating = 3.8, CategoryId = 2, Price = 4.99m }
                });
            }

            // Seed Purchases
            if (!context.Purchases.Any())
            {
                context.Purchases.AddRange(new[]
                {
                    new Purchase { UserId = 1, AppId = 1, PurchaseDate = System.DateTime.Now },
                    new Purchase { UserId = 2, AppId = 2, PurchaseDate = System.DateTime.Now }
                });
            }

            context.SaveChanges();
        }
    }
}
