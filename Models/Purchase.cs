using System;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int AppId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        public App App { get; set; } = new App(); // Ensure non-null reference
        public User User { get; set; } = new User(); // Ensure non-null reference
    }
}
