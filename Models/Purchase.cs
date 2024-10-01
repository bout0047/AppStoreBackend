namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public User User { get; set; } = new User(); // Initialize to avoid null warnings
        public int UserId { get; set; }
        public ApplicationData App { get; set; } = new ApplicationData(); // Initialize to avoid null warnings
        public int AppId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
