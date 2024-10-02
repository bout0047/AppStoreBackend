using AppStoreBackend.Services;

public class AppService : IAppService
{
    private readonly ApplicationDbContext _context;

    public AppService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> DeleteAppAsync(int id)
    {
        // Find the app by ID
        var app = await _context.Apps.FindAsync(id);

        // If not found, return false
        if (app == null)
        {
            return false;
        }

        // Remove the app from the context
        _context.Apps.Remove(app);

        // Save changes asynchronously
        await _context.SaveChangesAsync();

        // Return true indicating success
        return true;
    }
}
