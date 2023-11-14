using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<TaskBase> tasks = await _taskRepository.GetAllAsync();
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
        public IActionResult Create(TaskBase task)
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
        public async Task<IActionResult> Update(int id, TaskBase task)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "task update failed.");
                return View("Update", task);
            }
            _taskRepository.Update(task);
            return RedirectToAction("Index");
        }
    }
}
