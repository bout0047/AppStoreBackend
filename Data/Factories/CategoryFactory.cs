using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static Category Create(string name, string iconPath)
        {
            return new Category
            {
                CategoryName = name,
                IconPath = iconPath
            };
        }
    }
}
