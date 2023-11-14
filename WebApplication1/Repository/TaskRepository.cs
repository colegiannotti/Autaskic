using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(TaskModel model)
        {
            _context.Add(model);
            return Save();
        }

        public bool Delete(TaskModel model)
        {
            _context.Remove(model);
            return Save();
        }

        public async Task<IEnumerable<TaskModel>> GetAllAsync()
        {
            return await _context.Tasks.Include("Costs").ToListAsync();
        }

        public async Task<TaskModel> GetByIdAsync(int id)
        {
            return await _context.Tasks.Include("Costs").FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskModel model)
        {
            _context.Update(model);
            return Save();
        }
    }
}
