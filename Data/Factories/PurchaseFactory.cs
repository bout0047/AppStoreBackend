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
                User = new User(), // Add appropriate User object if needed
                App = new App() // Add appropriate App object if needed
            };
        }
    }
}
