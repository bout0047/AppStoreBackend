using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static Category CreateCategory(string name, string description, string? iconPath = null)
        {
            return new Category
            {
                Name = name,
                Description = description,
                IconPath = iconPath  // Added this line to match the updated model
            };
        }
    }
}
