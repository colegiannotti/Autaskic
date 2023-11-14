using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskBase>> GetAllAsync();
        Task<TaskBase> GetByIdAsync(int id);
        bool Add(TaskBase model);
        bool Update(TaskBase model);
        bool Delete(TaskBase model);
        bool Save();
    }
}
