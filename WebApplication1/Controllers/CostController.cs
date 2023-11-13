using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CostController : Controller
    {
        private readonly ICostRepository _costRepository;

        public CostController(ICostRepository costRepository)
        {
            _costRepository = costRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<CostModel> costs = await _costRepository.GetAllAsync();
            return View(costs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            CostModel cost = await _costRepository.GetByIdAsync(id);
            return View(cost);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CostModel cost)
        {
            if (!ModelState.IsValid)
            {
                return View(cost);
            }
            _costRepository.Add(cost);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var cost = await _costRepository.GetByIdAsync(id);
            return View(cost);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, CostModel cost)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Cost update failed.");
                return View("Update", cost);
            }
            _costRepository.Update(cost);
            return RedirectToAction("Index");
        }
    }
}
