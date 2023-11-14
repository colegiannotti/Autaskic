using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskModel>> GetAllAsync();
        Task<TaskModel> GetByIdAsync(int id);
        bool Add(TaskModel model);
        bool Update(TaskModel model);
        bool Delete(TaskModel model);
        bool Save();
    }
}
