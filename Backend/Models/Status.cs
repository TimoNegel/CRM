namespace Backend.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public virtual ICollection<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
    }
}
