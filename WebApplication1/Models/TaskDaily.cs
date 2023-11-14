namespace WebApplication1.Models
{
    public class TaskDaily
    {
        public int Id { get; set; }
        public bool Skippable { get; set; }
        public virtual TaskBase Task { get; set; } = null!;

    }
}
