using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class AppFactory
    {
        public static App CreateApp(int categoryId, string name, string description, decimal price)
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
