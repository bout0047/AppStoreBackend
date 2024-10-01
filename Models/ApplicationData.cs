namespace AppStoreBackend.Models
{
    public class ApplicationData
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Default value
        public string Description { get; set; } = string.Empty; // Default value
        public Category Category { get; set; } = new Category(); // Default value to avoid null warnings
    }
}
