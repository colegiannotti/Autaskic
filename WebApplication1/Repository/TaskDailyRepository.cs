using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TaskDailyRepository : ITaskDailyRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskDailyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(TaskDaily entity)
        {
            _context.Add(entity);
            return Save();
        }

        public bool Delete(TaskDaily entity)
        {
            var viewModel = _context.TasksDaily.Where(i => i.Id == entity.Id).FirstOrDefault();
            _context.Entry(viewModel).State = EntityState.Deleted;
            return Save();
        }

        public async Task<IEnumerable<TaskDaily>> GetAllAsync()
        {
            return await _context.TasksDaily.ToListAsync();
        }

        public async Task<TaskDaily> GetByIdAsync(int id)
        {
            return await _context.TasksDaily.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(TaskDaily entity)
        {
            _context.Update(entity);
            return Save();
        }
    }
}
