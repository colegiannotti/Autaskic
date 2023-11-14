using WebApplication1.Models;
using System;

namespace WebApplication1.Data
{
    public static class Seed
    {
        public static TaskBase TaskSeed { get; private set; } = new TaskBase()
        {
            Id = 1,
            Name = "Example Task",
            Description = "Example Description",
            Energy = 5, 
            Enjoyment = 5,
            TimeSpan = TimeSpan.FromMinutes(30),
            Priority = 1,
            LastCompletedDate = DateTime.Now,
            Tolerance = 5,
            TimeOfDay = TimeOnly.Parse("8:00")
        };
    }

}
