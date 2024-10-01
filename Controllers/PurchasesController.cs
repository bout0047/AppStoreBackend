using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data;
using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchasesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPurchases()
        {
            List<Purchase> purchases = _context.Purchases.ToList();
            return Ok(purchases);
        }
    }
}
