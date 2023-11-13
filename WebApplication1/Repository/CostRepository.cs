using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CostRepository : ICostRepository
    {
        private readonly ApplicationDbContext _context;

        public CostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CostModel model)
        {
            _context.Add(model);
            return Save();
        }

        public bool Delete(CostModel model)
        {
            _context.Remove(model);
            return Save();
        }

        public async Task<IEnumerable<CostModel>> GetAllAsync()
        {
            return await _context.Costs.ToListAsync();
        }

        public async Task<CostModel> GetByIdAsync(int id)
        {
            return await _context.Costs.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(CostModel model)
        {
            _context.Update(model);
            return Save();
        }
    }
}
