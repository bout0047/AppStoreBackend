namespace AppStoreBackend.Models
{
    public class App
    {
        public int AppID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool? IsPopular { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
