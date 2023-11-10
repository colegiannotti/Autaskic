using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey("CostModel")]
        public int CostModelId { get; set; }
        public CostModel? Cost { get; set; }
        public int Priority { get; set; }
        public DateTime LastCompletedDate { get; set; }
        public int Tolerance { get; set; }
        public ICollection<StepModel> Steps { get; set; } = new List<StepModel>();
        public TimeOnly TimeOfDay { get; set; }
    }
}
