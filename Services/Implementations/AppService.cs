using AppStoreBackend.Models;

namespace AppStoreBackend.Services.Implementations
{
    public class AppService
    {
        public string GetCategoryName(Category category)
        {
            return category.Name; // Updated property reference
        }
    }
}
