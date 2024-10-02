using AppStoreBackend.Data;
using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services.Implementations
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

        public async Task CreateAppAsync(App app)
        {
            _context.Apps.Add(app);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppAsync(int id, App app)
        {
            var existingApp = await _context.Apps.FindAsync(id);
            if (existingApp != null)
            {
                existingApp.Name = app.Name;
                existingApp.Description = app.Description;
                existingApp.Category = app.Category;

                _context.Apps.Update(existingApp);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> DeleteAppAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app != null)
            {
                _context.Apps.Remove(app);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
