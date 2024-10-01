using AppStoreBackend.Data;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Seeders
{
    public class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            // Example seeding logic
            if (!context.Categories.Any())
            {
                var category = new Category
                {
                    CategoryName = "Games",
                    IconPath = "/images/games.png"
                };

                context.Categories.Add(category);
                context.SaveChanges();
            }

            if (!context.Apps.Any()) // Updated from context.Apps to context.Apps, which uses ApplicationData
            {
                var app = new ApplicationData
                {
                    Name = "Super Fun Game",
                    Description = "An exciting game for all ages.",
                    Category = context.Categories.First() // Assuming there's at least one category
                };

                context.Apps.Add(app);
                context.SaveChanges();
            }
        }
    }
}
