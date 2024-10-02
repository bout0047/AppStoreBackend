using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class AppFactory
    {
        public static App CreateNewApp(string name, string description, Category category)
        {
            return new App
            {
                Name = name,
                Description = description,
                Category = category // Correct usage of Category property
            };
        }
    }
}
