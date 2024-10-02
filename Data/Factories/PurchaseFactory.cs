using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class PurchaseFactory
    {
        public static Purchase CreateNewPurchase(int userId, int appId, DateTime purchaseDate)
        {
            return new Purchase
            {
                UserId = userId,
                AppId = appId,
                PurchaseDate = purchaseDate,
                User = new User(), // Correct reference
                App = new App() // Correct reference
            };
        }
    }
}
