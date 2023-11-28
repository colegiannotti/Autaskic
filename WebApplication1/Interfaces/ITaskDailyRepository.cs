using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskDailyRepository
    {
        Task<IEnumerable<TaskDaily>> GetAllAsync();
        Task<IEnumerable<TaskDaily>> GetAllAsyncByPriority();
        Task<TaskDaily> GetByIdAsync(int id);
        bool Add(TaskDaily model);
        bool Update(TaskDaily model);
        bool Delete(TaskDaily model);
        bool Save();
    }
}
