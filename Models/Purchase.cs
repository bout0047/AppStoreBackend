namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!; // Ensuring that this value will be non-null
        public int AppId { get; set; }
        public App App { get; set; } = null!; // Ensuring that this value will be non-null
        public DateTime PurchaseDate { get; set; } // Added PurchaseDate property
    }
}
