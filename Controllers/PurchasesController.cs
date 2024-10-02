using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Data; // Import for AppDbContext
using AppStoreBackend.Models; // Import models like Purchase

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchasesController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public IActionResult CreatePurchase(Purchase purchase)
        {
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
