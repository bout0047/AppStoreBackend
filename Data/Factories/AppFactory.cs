using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class AppFactory
    {
        public static App Create(string name, string description, decimal price, int categoryId)
        {
            return new App
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = categoryId
            };
        }
    }
}
