using WebApplication1.Data.Enum;

namespace WebApplication1.Models
{
    public class TaskPeriodic
    {
        public int Id { get; set; }
        public int Period { get; set; }
        public PeriodEnum Unit { get; set; }
        public virtual TaskBase Task { get; set; } = null!;
    }
}
