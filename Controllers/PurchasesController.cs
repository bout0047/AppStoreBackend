using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Models;
using AppStoreBackend.Data;
using System.Threading.Tasks;

namespace AppStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchasesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Purchase>> MakePurchase(Purchase purchase)
        {
            _context.Purchases.Add(purchase);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(MakePurchase), new { id = purchase.PurchaseID }, purchase);
        }
    }
}
