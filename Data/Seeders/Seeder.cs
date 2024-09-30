using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Seeders
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Games", Description = "Gaming apps" },
                    new Category { Name = "Productivity", Description = "Productivity tools" }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User { Username = "user1", Email = "user1@example.com", Password = "password123" },
                    new User { Username = "user2", Email = "user2@example.com", Password = "password123" }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Apps.Any())
            {
                var apps = new List<App>
                {
                    new App { Name = "Sample App 1", Description = "This is a sample app", Price = 9.99M, CategoryId = 1 },
                    new App { Name = "Sample App 2", Description = "This is another sample app", Price = 4.99M, CategoryId = 2 }
                };
                context.Apps.AddRange(apps);
                context.SaveChanges();
            }
        }
    }
}
