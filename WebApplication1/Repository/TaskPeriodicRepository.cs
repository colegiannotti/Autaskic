using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TaskPeriodicRepository : ITaskPeriodicRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskPeriodicRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(TaskPeriodic entity)
        {
            _context.Add(entity);
            return Save();
        }

        public bool Delete(TaskPeriodic entity)
        {
            var viewModel = _context.TasksPeriodic.Where(i => i.Id == entity.Id).FirstOrDefault();
            _context.Entry(viewModel).State = EntityState.Deleted;
            return Save();
        }

        public async Task<IEnumerable<TaskPeriodic>> GetAllAsync()
        {
            return await _context.TasksPeriodic.ToListAsync();
        }

        public async Task<TaskPeriodic> GetByIdAsync(int id)
        {
            return await _context.TasksPeriodic.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskPeriodic entity)
        {
            _context.Update(entity);
            return Save();
        }
    }
}
