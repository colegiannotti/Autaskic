namespace WebApplication1.Models
{
    public class Week
    {
        public int Id { get; set; }
        public DateTime[] DayStart { get; set; } = new DateTime[7];
        public DateTime[] DayEnd { get; set; } = new DateTime[7];
    }
}
