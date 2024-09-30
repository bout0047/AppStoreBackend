using AppStoreBackend.Data;
using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Linq;

public class Seeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Categories.Any())
        {
            context.Categories.AddRange(new[]
            {
                new Category { Name = "Games", Description = "All games." },
                new Category { Name = "Music", Description = "All music." },
            });
            context.SaveChanges();
        }

        // Add similar logic for Apps
    }
}
