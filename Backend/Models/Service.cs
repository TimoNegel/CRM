namespace Backend.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string ServiceName { get; set; } = string.Empty;
        public TimeSpan AufwandsZeit { get; set; }
        public decimal Preis { get; set; }

        // Many-to-Many mit Auftrag
        public virtual ICollection<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
    }
}
