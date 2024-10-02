using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static Category CreateNewCategory(string name, string description, string iconPath)
        {
            return new Category
            {
                Name = name,
                Description = description, // Correct usage of Description property
                IconPath = iconPath // Correct usage of IconPath property
            };
        }
    }
}
