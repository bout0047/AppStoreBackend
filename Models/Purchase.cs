namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int UserID { get; set; }
        public int AppID { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
