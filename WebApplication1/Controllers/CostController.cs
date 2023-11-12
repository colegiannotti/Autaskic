using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CostController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var costs = _context.Costs.ToList();
            return View(costs);
        }
    }
}
