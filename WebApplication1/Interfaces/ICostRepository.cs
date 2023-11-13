using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ICostRepository
    {
        Task<IEnumerable<CostModel>> GetAllAsync();
        Task<CostModel> GetByIdAsync(int id);
        bool Add (CostModel model);
        bool Update (CostModel model);
        bool Delete (CostModel model);
        bool Save();

    }
}
