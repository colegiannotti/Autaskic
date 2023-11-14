using WebApplication1.Models;
using System;

namespace WebApplication1.Data
{
    public static class Seed
    {
        /*public static void SeedData(this WebApplication app)
        
        {
            using var scope = app.Services.CreateScope();
            ApplicationDbContext _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (!_context.Costs.Any())
            {
                _context.Costs.Add(new Models.CostModel()
                {
                    Energy = 10,
                    Enjoyment = 5,
                    TimeSpan = TimeSpan.Zero
                });

                _context.Costs.Add(new Models.CostModel()
                {
                    Energy = 2,
                    Enjoyment = 4,
                    TimeSpan = TimeSpan.FromMinutes(30)
                });
            }
            _context.SaveChanges();

            if (!_context.Tasks.Any())
            {
                _context.Tasks.Add(new Models.TaskModel()
                {
                    Name = "First Task",
                    Description = "Task Description here",
                    Cost = _context.Costs.First()
                });

            }
            _context.SaveChanges();
        }*/

        private static Random rand = new Random();
        public const int CostLength = 10;
        public static List<CostModel> Costs { get; private set; }
        public static void RandomizeCosts()
        {
            Costs = new List<CostModel>();
            for (int i = 0; i < CostLength; i++)
            {
                Costs.Add(new CostModel()
                {
                    Id = i + 1,
                    Energy = rand.Next(10) + 1,
                    Enjoyment = rand.Next(10) + 1,
                    TimeSpan = TimeSpan.FromMinutes((rand.Next(12) + 1) * 5)
                });
            }
        }

        public static List<TaskModel> Tasks { get; private set; } = new List<TaskModel>
        {
            new TaskModel()
            {
                Id = 1,
                Name = "Example Task",
                Description = "Example Description",
                LastCompletedDate = DateTime.Now,
                TimeOfDay = TimeOnly.Parse("8:00"),
                Tolerance = rand.Next(10) + 1,
                Priority = rand.Next(10) + 1,
                Steps = new List<StepModel>(),
                CostModelId = 1
            }
        };
    }

}
