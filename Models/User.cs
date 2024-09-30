namespace AppStoreBackend.Models
{
    public class User
    {
        public int UserID { get; set; }                 // Added UserID property
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
