using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskTransientRepository
    {
        Task<IEnumerable<TaskTransient>> GetAllAsync();
        Task<TaskTransient> GetByIdAsync(int id);
        bool Add(TaskTransient model);
        bool Update(TaskTransient model);
        bool Delete(TaskTransient model);
        bool Save();
    }
}
