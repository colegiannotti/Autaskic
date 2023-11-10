namespace WebApplication1.Data
{
    public static class Seed
    {
        public static void SeedData(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (!context.Costs.Any())
            {
                context.Costs.Add(new Models.CostModel()
                {
                    Energy = 10,
                    Enjoyment = 5,
                    TimeSpan = TimeSpan.Zero
                });

                context.Costs.Add(new Models.CostModel()
                {
                    Energy = 2,
                    Enjoyment = 4,
                    TimeSpan = TimeSpan.FromMinutes(30)
                });
            }
            context.SaveChanges();

            if (!context.Tasks.Any())
            {
                context.Tasks.Add(new Models.TaskModel()
                {
                    Name = "First Task",
                    Description = "Task Description here",
                    Cost = context.Costs.First()
                });

            }
            context.SaveChanges();
        }
    }
}
