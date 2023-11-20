using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TaskTransientRepository : ITaskTransientRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskTransientRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(TaskTransient entity)
        {
            _context.Add(entity);
            return Save();
        }

        public bool Delete(TaskTransient entity)
        {
            var viewModel = _context.TasksTransient.Where(i => i.Id == entity.Id).FirstOrDefault();
            _context.Entry(viewModel).State = EntityState.Deleted;
            return Save();
        }

        public async Task<IEnumerable<TaskTransient>> GetAllAsync()
        {
            return await _context.TasksTransient.ToListAsync();
        }

        public async Task<TaskTransient> GetByIdAsync(int id)
        {
            return await _context.TasksTransient.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskTransient entity)
        {
            _context.Update(entity);
            return Save();
        }
    }
}
