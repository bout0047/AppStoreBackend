using System.Collections.Generic;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static List<Category> CreateCategories()
        {
            return new List<Category>
            {
                new Category { Name = "Games", Description = "All kinds of games" },
                new Category { Name = "Music", Description = "Music apps and tools" }
            };
        }
    }
}
