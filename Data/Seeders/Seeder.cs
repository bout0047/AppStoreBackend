using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

public static class Seeder
{
    public static async Task Seed(UserManager<IdentityUser> userManager)
    {
        if (await userManager.FindByNameAsync("testuser") == null)
        {
            var user = new IdentityUser
            {
                UserName = "testuser",
                Email = "testuser@example.com",
                EmailConfirmed = true
            };
            await userManager.CreateAsync(user, "Test@123"); // Replace with your desired password.
        }
    }
}
