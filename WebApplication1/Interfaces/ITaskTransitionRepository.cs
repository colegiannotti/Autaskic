using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskTransitionRepository
    {
        Task<IEnumerable<TaskTransition>> GetAllAsync();
        Task<TaskTransition> GetByIdAsync(int id);
        bool Add(TaskTransition model);
        bool Update(TaskTransition model);
        bool Delete(TaskTransition model);
        bool Save();
    }
}
