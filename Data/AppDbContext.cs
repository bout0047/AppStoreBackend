using AppStoreBackend.Models;
using System.Linq;

namespace AppStoreBackend.Data
{
    public static class AppDbContextSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(UserFactory.CreateUsers());
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(CategoryFactory.CreateCategories());
            }

            if (!context.Purchases.Any())
            {
                context.Purchases.AddRange(PurchaseFactory.CreatePurchases());
            }

            context.SaveChanges();
        }
    }
}
