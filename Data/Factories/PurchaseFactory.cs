using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class PurchaseFactory
    {
        public static Purchase Create(int userId, int appId)
        {
            return new Purchase
            {
                UserId = userId,
                AppId = appId
            };
        }
    }
}
