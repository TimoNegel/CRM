namespace Backend.Models
{
    public class Auftrag
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal AuftragsValue { get; set; }

        public Guid KundenId { get; set; }
        public virtual  Kunde Kunde { get; set; }

        public Guid StatusId { get; set; }
        public virtual  Status Status { get; set; }

        // Many-to-Many mit Service
        public virtual ICollection<Service> Services { get; set; } = new List<Service>();

        // Navigation Property
        public virtual ICollection<Rechnung> Rechnungen { get; set; } = new List<Rechnung>();
    }
}