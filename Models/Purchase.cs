namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        // Foreign Key for User
        public int UserId { get; set; }

        // Navigation property for User
        public User User { get; set; } = null!;

        // Foreign Key for App
        public int AppId { get; set; }

        // Navigation property for App
        public App App { get; set; } = null!;
    }
}
