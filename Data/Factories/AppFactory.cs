using AppStoreBackend.Models; // Assuming Category is defined in Models

namespace AppStoreBackend.Data.Factories
{
    public static class AppFactory
    {
        public static ApplicationData CreateApp(string name, string description, Category category)
        {
            return new ApplicationData
            {
                Name = name,
                Description = description,
                Category = category
            };
        }
    }
}
