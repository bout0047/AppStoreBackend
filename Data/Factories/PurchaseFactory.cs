using System.Collections.Generic;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories // Corrected namespace
{
    public static class PurchaseFactory
    {
        public static List<Purchase> CreatePurchases()
        {
            return new List<Purchase>
            {
                new Purchase { UserId = 1, AppId = 1, PurchaseDate = System.DateTime.Now },
                new Purchase { UserId = 2, AppId = 2, PurchaseDate = System.DateTime.Now }
            };
        }
    }
}
