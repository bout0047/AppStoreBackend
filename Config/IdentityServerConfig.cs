namespace AppStoreBackend.Config
{
    public class IdentityServerConfig
    {
        public static string IssuerUri { get; set; } = "https://localhost:5001";
        public static string ApiName { get; set; } = "appstore_api";
        public static string ApiSecret { get; set; } = "appstore_secret";

        // Other identity server configuration settings...
    }
}
