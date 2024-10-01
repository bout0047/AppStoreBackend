namespace AppStoreBackend.DTOs
{
    public class PurchaseDTO
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
    }
}
