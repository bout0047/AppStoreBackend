namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty; // Added Username property
        public string Password { get; set; } = string.Empty; // Added Password property
        // Add any other necessary properties here
    }
}
