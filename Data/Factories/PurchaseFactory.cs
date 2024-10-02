using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class PurchaseFactory
    {
        public static Purchase CreatePurchase(User? user, App? app)
        {
            return new Purchase
            {
                User = user ?? throw new ArgumentNullException(nameof(user)),
                App = app ?? throw new ArgumentNullException(nameof(app))
            };
        }
    }
}
