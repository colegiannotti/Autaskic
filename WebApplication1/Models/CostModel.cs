using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CostModel
    {
        [Key]
        public int Id { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public int Energy { get; set; }
        public int Enjoyment { get; set; }
    }
}
