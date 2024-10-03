using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppDTO>>> GetApps()
        {
            var apps = await _context.Apps
                .Include(a => a.Category)
                .Select(a => new AppDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    CategoryId = a.CategoryId,
                    CategoryName = a.Category.Name
                })
                .ToListAsync();

            return Ok(apps);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppDTO>> GetApp(int id)
        {
            var app = await _context.Apps
                .Include(a => a.Category)
                .Where(a => a.Id == id)
                .Select(a => new AppDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    CategoryId = a.CategoryId,
                    CategoryName = a.Category.Name
                })
                .FirstOrDefaultAsync();

            if (app == null)
            {
                return NotFound();
            }

            return Ok(app);
        }

        [HttpPost]
        public async Task<ActionResult<App>> CreateApp(AppDTO appDTO)
        {
            var app = new App
            {
                Name = appDTO.Name,
                Description = appDTO.Description,
                CategoryId = appDTO.CategoryId
            };

            _context.Apps.Add(app);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApp), new { id = app.Id }, appDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApp(int id, AppDTO appDTO)
        {
            if (id != appDTO.Id)
            {
                return BadRequest();
            }

            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return NotFound();
            }

            app.Name = appDTO.Name;
            app.Description = appDTO.Description;
            app.CategoryId = appDTO.CategoryId;

            _context.Entry(app).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApp(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app == null)
            {
                return NotFound();
            }

            _context.Apps.Remove(app);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppExists(int id)
        {
            return _context.Apps.Any(e => e.Id == id);
        }
    }
}
