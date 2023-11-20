using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskPeriodicRepository
    {
        Task<IEnumerable<TaskPeriodic>> GetAllAsync();
        Task<TaskPeriodic> GetByIdAsync(int id);
        bool Add(TaskPeriodic model);
        bool Update(TaskPeriodic model);
        bool Delete(TaskPeriodic model);
        bool Save();
    }
}
