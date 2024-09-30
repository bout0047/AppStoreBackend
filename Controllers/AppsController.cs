using AppStoreBackend.Data;
using AppStoreBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<IEnumerable<App>>> GetApps()
        {
            return await _context.Apps.Include(a => a.Category).ToListAsync();
        }
    }
}
