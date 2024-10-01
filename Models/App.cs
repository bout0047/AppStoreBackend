namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        // Define foreign key and relationship to Category
        public required Category Category { get; set; }

        // Collection of purchases related to this app
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
