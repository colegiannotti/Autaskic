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
            modelBuilder.Entity<TaskDaily>().HasData(Seed.TaskDailySeed);
            modelBuilder.Entity<TaskPeriodic>().HasData(Seed.TaskPeriodicSeed);
            modelBuilder.Entity<TaskTransient>().HasData(Seed.TaskTransientSeed);
            modelBuilder.Entity<TaskTransition>().HasData(Seed.TaskTransitionSeed);
            modelBuilder.Entity<Week>()
                .Ignore("DayEnd")
                .Ignore("DayStart");
        }

        public DbSet<TaskDaily> TasksDaily { get; set; }
        public DbSet<TaskPeriodic> TasksPeriodic { get; set; }
        public DbSet<TaskTransient> TasksTransient { get; set; }
        public DbSet<TaskTransition> TasksTransition { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Step> Steps { get; set; }   
    }
}
