namespace AppStoreBackend.DTOs
{
    public class AppDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure non-null value is always assigned
        public string Description { get; set; } = string.Empty; // Ensure non-null value is always assigned
    }
}
