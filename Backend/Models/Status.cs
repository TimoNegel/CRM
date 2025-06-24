namespace Backend.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public int Position { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Name { get; set; } = string.Empty;

        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; }

        // Navigation Properties
        public virtual ICollection<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
    }
}
