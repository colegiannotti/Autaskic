using WebApplication1.Models;
using System;

namespace WebApplication1.Data
{
    public static class Seed
    {
        public static TaskDaily TaskDailySeed { get; private set; } = new TaskDaily()
        {
            Id = 1,
            Name = "Example Daily Task",
            Description = "Example Description",
            Energy = 5, 
            Enjoyment = 5,
            TimeSpan = TimeSpan.FromMinutes(30),
            Priority = 1,
            LastCompletedDate = DateTime.Now,
            Tolerance = 5,
            TimeOfDay = TimeOnly.Parse("8:00"),
            Skippable = true
        };

        public static TaskPeriodic TaskPeriodicSeed { get; private set; } = new TaskPeriodic()
        {
            Id = 2,
            Name = "Example Periodic Task",
            Description = "Example Description",
            Energy = 5,
            Enjoyment = 5,
            TimeSpan = TimeSpan.FromMinutes(30),
            Priority = 1,
            LastCompletedDate = DateTime.Now,
            Tolerance = 5,
            TimeOfDay = TimeOnly.Parse("8:00"),
            Unit = Enum.PeriodEnum.Month,
            Period = 1
        };

        public static TaskTransient TaskTransientSeed { get; private set; } = new TaskTransient()
        {
            Id = 3,
            Name = "Example Transient Task",
            Description = "Example Description",
            Energy = 5,
            Enjoyment = 5,
            TimeSpan = TimeSpan.FromMinutes(30),
            Priority = 1,
            LastCompletedDate = DateTime.Now,
            Tolerance = 5,
            TimeOfDay = TimeOnly.Parse("8:00"),
            DueDate = DateTime.Now
        };

        public static TaskTransition TaskTransitionSeed { get; private set; } = new TaskTransition()
        {
            Id = 4,
            Name = "Example Periodic Task",
            Description = "Example Description",
            Energy = 5,
            Enjoyment = 5,
            TimeSpan = TimeSpan.FromMinutes(30),
            Priority = 1,
            LastCompletedDate = DateTime.Now,
            Tolerance = 5,
            TimeOfDay = TimeOnly.Parse("8:00"),
        };
    }

}
