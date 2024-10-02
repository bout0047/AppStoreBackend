using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Models; // Use Models for all entities like Purchase

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

        [HttpPost]
        public IActionResult CreatePurchase(Purchase purchase)
        {
            // Explicitly using the correct namespace
            _context.Purchases.Add(purchase);
            _context.SaveChanges();

            return Ok(purchase);
        }

        [HttpGet("{id}")]
        public IActionResult GetPurchase(int id)
        {
            var purchase = _context.Purchases.Find(id);
            if (purchase == null)
            {
                return NotFound();
            }

            return Ok(purchase);
        }
    }
}
