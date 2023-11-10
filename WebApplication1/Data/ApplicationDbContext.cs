using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<CostModel> Costs { get; set; }
        public DbSet<StepModel> Steps { get; set; }   
    }
}
