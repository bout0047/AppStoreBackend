namespace AppStoreBackend.DTOs
{
    public class AppDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty; // Ensure non-nullable with default value
    }
}
