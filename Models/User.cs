namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Ensure non-null value
        public string Email { get; set; } = string.Empty; // Ensure non-null value
        public string Name { get; set; } = string.Empty; // Added Name property
        public string Password { get; set; } = string.Empty; // Added Password property
    }
}
