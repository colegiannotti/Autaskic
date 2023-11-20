using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TaskPeriodicController : Controller
    {
        private readonly ITaskPeriodicRepository _taskRepository;
        public TaskPeriodicController(ITaskPeriodicRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<TaskPeriodic> tasks = await _taskRepository.GetAllAsync();
            return View(tasks);
        }

        public async Task<IActionResult> Detail(int id)
        {
            TaskBase task = await _taskRepository.GetByIdAsync(id);
            return View(task);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(TaskPeriodic task)
        {
            if (!ModelState.IsValid)
            {
                return View(task);
            }
            _taskRepository.Add(task);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, TaskPeriodic task)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "task update failed.");
                return View("Update", task);
            }
            _taskRepository.Update(task);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _taskRepository.GetByIdAsync(id);
            if (entity == null) { return View("Error"); }
            _taskRepository.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
