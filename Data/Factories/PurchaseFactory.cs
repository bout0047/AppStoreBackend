using System;
using AppStoreBackend.Data; // Added using statement to reference ApplicationData

namespace AppStoreBackend.Models
{
    public class PurchaseData
    {
        public int Id { get; set; }

        // Reference to the user who made the purchase
        public User User { get; set; } // Consider initializing to avoid null warnings
        public int UserId { get; set; } // Added foreign key property for User

        // Reference to the application being purchased
        public ApplicationData App { get; set; } // Consider initializing to avoid null warnings
        public int AppId { get; set; } // Added foreign key property for App

        // Additional properties
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
