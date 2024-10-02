using IdentityServer4.Models;
using System.Collections.Generic;

namespace AppStoreBackend.Config
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("appstore_api", "App Store API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "appstore_api" }
                }
            };
    }
}
