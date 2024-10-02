using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class PurchaseFactory
    {
        public static Purchase CreatePurchase(int id, int userId, int appId, DateTime purchaseDate)
        {
            return new Purchase
            {
                Id = id,
                UserId = userId,
                AppId = appId,
                PurchaseDate = purchaseDate // Ensure PurchaseDate is assigned
            };
        }
    }
}
