using AppStoreBackend.Data;
using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Services
{
    public class AppService : IAppService
    {
        private readonly AppDbContext _context;

        public AppService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<App>> GetAllAppsAsync()
        {
            return await _context.Apps.Include(a => a.Category).ToListAsync();
        }

        public async Task<App> GetAppByIdAsync(int id)
        {
            return await _context.Apps.Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAppAsync(App app)
        {
            await _context.Apps.AddAsync(app);
            await _context.SaveChangesAsync();
        }

        // Implement other methods if needed
    }
}
