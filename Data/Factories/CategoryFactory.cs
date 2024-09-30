using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static Category Create(string categoryName, string iconPath)
        {
            return new Category
            {
                CategoryName = categoryName,
                IconPath = iconPath
            };
        }
    }
}
