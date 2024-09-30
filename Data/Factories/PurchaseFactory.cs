using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class PurchaseFactory
    {
        public static Purchase CreatePurchase(int userId, int appId, DateTime purchaseDate)
        {
            return new Purchase
            {
                UserId = userId,
                AppId = appId,
                PurchaseDate = purchaseDate
            };
        }
    }
}
