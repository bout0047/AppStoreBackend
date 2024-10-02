namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure a default value
        public string Description { get; set; } = string.Empty; // Ensure a default value
    }
}
