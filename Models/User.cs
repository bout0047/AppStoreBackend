namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }   // Add this if missing
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
