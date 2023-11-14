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
        public bool Add(TaskBase entity)
        {
            _context.Add(entity);
            return Save();
        }

        public bool Delete(TaskBase entity)
        {
            _context.Remove(entity);
            return Save();
        }

        public async Task<IEnumerable<TaskBase>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskBase> GetByIdAsync(int id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskBase entity)
        {
            _context.Update(entity);
            return Save();
        }
    }
}
