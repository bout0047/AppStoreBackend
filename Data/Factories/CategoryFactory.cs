using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class CategoryFactory
    {
        public static Category CreateDefaultCategory()
        {
            return new Category
            {
                Name = "Default Category",
                Description = "Default Description", // Adding the Description property
                IconPath = "/images/default.png" // Adding the IconPath property
            };
        }
    }
}
