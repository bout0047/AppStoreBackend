namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        // Required relationships
        public required User User { get; set; }

        public required App App { get; set; }
    }
}
