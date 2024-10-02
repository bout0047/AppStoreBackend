using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Services.Implementations
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
            return await _context.Apps
                .Select(app => new AppDTO
                {
                    Id = app.Id,
                    Name = app.Name,
                    Description = app.Description
                })
                .ToListAsync();
        }

        public async Task<AppDTO> GetAppByIdAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return null;
            }

            return new AppDTO
            {
                Id = app.Id,
                Name = app.Name,
                Description = app.Description
            };
        }

        public async Task CreateAppAsync(AppDTO appDto)
        {
            var app = new App
            {
                Name = appDto.Name,
                Description = appDto.Description
            };

            _context.Apps.Add(app);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppAsync(int id, AppDTO appDto)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return;
            }

            app.Name = appDto.Name;
            app.Description = appDto.Description;

            _context.Apps.Update(app);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return;
            }

            _context.Apps.Remove(app);
            await _context.SaveChangesAsync();
        }
    }
}
