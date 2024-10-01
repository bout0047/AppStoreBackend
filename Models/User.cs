namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public required string Password { get; set; }

        public required string Email { get; set; }

        // List of purchases by the user
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
