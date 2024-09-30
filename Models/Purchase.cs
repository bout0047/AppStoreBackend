using System;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!; // Non-null reference

        public int AppId { get; set; }
        public App App { get; set; } = null!; // Non-null reference

        public DateTime PurchaseDate { get; set; }
    }
}
