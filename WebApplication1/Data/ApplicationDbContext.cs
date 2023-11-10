using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public static string DbPath
        {
            get
            {
                const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                return Path.Join(path, "Autaskic.db");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed.RandomizeCosts();
            for(int i = 0; i < Seed.Costs.Count; i++)
            {
                modelBuilder.Entity<CostModel>().HasData(Seed.Costs[i]);
            }
            modelBuilder.Entity<TaskModel>().HasData(Seed.Tasks[0]);
            
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<CostModel> Costs { get; set; }
        public DbSet<StepModel> Steps { get; set; }   
    }
}
