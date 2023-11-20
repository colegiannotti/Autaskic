using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TaskTransitionRepository : ITaskTransitionRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskTransitionRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(TaskTransition entity)
        {
            _context.Add(entity);
            return Save();
        }

        public bool Delete(TaskTransition entity)
        {
            var viewModel = _context.TasksTransition.Where(i => i.Id == entity.Id).FirstOrDefault();
            _context.Entry(viewModel).State = EntityState.Deleted;
            return Save();
        }

        public async Task<IEnumerable<TaskTransition>> GetAllAsync()
        {
            return await _context.TasksTransition.ToListAsync();
        }

        public async Task<TaskTransition> GetByIdAsync(int id)
        {
            return await _context.TasksTransition.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskTransition entity)
        {
            _context.Update(entity);
            return Save();
        }
    }
}
