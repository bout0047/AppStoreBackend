using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Models;
using AppStoreBackend.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<App>>> GetApps()
        {
            var apps = await _context.Apps.ToListAsync();
            return Ok(apps); // Ensure you are returning correct data
        }

        [HttpGet("popularApps")]
        public async Task<ActionResult<IEnumerable<App>>> GetPopularApps()
        {
            var apps = await _context.Apps
                                     .Where(app => app.IsPopular)  // Filter based on IsPopular
                                     .ToListAsync();
            return Ok(apps);
        }


        [HttpPost]
        public async Task<ActionResult<App>> CreateApp(App app)
        {
            _context.Apps.Add(app);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetApps), new { id = app.AppID }, app);
        }
    }
}
