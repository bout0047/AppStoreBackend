namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Added Username
        public string Password { get; set; } = string.Empty; // Added Password
        public string Email { get; set; } = string.Empty; // Added Email
    }
}
