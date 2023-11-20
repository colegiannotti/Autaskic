using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Data.Enum;

namespace WebApplication1.Models
{
    public abstract class TaskBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Energy { get; set; }
        public int Enjoyment { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public int Priority { get; set; }
        public DateTime LastCompletedDate { get; set; }
        public int Tolerance { get; set; }
        public ICollection<Step>? Steps { get; set; }
        public TimeOnly TimeOfDay { get; set; }        
    }
}
