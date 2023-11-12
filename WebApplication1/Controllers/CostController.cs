using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

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

        public IActionResult Detail(int id)
        {
            CostModel cost = _context.Costs.FirstOrDefault(x => x.Id == id);
            return View(cost);
        }
    }
}
