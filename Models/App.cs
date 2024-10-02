namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Foreign key property
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; } = new Category();
    }
}
