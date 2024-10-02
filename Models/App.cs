namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure non-null value
        public string Description { get; set; } = string.Empty; // Ensure non-null value
        public Category Category { get; set; } = new Category(); // Ensure non-null reference
    }
}
