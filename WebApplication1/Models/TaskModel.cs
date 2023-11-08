namespace WebApplication1.Models
{
    public class TaskModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CostModel? Cost { get; set; }
        public int Priority { get; set; }
        public DateTime LastCompletedDate { get; set; }
        public int Tolerance { get; set; }
        public List<StepModel> Steps { get; set; } = new List<StepModel>();
        public TimeOnly TimeOfDay { get; set; }
    }
}
