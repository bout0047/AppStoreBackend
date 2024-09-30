using System;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Navigation property
        public int AppId { get; set; }
        public App App { get; set; } // Navigation property
        public DateTime PurchaseDate { get; set; }
    }
}
