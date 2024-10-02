using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;

namespace AppStoreBackend.Services
{
    public class AppService : IAppService
    {
        private readonly AppDbContext _context;

        public AppService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppDTO>> GetAllAppsAsync()
        {
            return await _context.Apps.Select(a => new AppDTO
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                CategoryName = a.Category.CategoryName
            }).ToListAsync();
        }

        public async Task<AppDTO> GetAppByIdAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return null; // Consider throwing an exception instead.
            }
            return new AppDTO
            {
                Id = app.Id,
                Name = app.Name,
                Description = app.Description,
                CategoryName = app.Category.CategoryName
            };
        }

        public async Task CreateAppAsync(AppDTO appDto)
        {
            var app = new App
            {
                Name = appDto.Name,
                Description = appDto.Description,
                CategoryId = appDto.CategoryId
            };
            await _context.Apps.AddAsync(app);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppAsync(int id, AppDTO appDto)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                throw new KeyNotFoundException("App not found");
            }

            app.Name = appDto.Name;
            app.Description = appDto.Description;
            app.CategoryId = appDto.CategoryId;
            _context.Apps.Update(app);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                throw new KeyNotFoundException("App not found");
            }

            _context.Apps.Remove(app);
            await _context.SaveChangesAsync();
        }
    }
}
