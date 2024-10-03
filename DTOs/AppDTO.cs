namespace AppStoreBackend.DTOs
{
    public class AppDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure these fields are initialized to avoid nullable warnings
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty; // Ensure this closing brace exists
    }
}
