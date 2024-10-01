using System;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        // Foreign key for User
        public int UserId { get; set; }
        public required User User { get; set; }

        // Foreign key for App
        public int AppId { get; set; }
        public required App App { get; set; }
    }
}
