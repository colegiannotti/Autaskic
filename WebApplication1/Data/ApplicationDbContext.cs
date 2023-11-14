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
                        
            modelBuilder.Entity<TaskBase>().HasData(Seed.TaskSeed);
        }

        public DbSet<TaskBase> Tasks { get; set; }
        public DbSet<Step> Steps { get; set; }   
    }
}
