using WebApplication1.Data.Enum;

namespace WebApplication1.Models
{
    public class TaskPeriodic : TaskBase
    {
        public int Period { get; set; }
        public PeriodEnum Unit { get; set; }
    }
}
