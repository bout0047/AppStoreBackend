namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
