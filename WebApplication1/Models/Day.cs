namespace WebApplication1.Models
{
    public class Day
    {
        public int Id { get; set; }
        public IEnumerable<TaskBase>? Tasks { get; set; }
        public int PredictedEnergy { get; set; }
    }
}
