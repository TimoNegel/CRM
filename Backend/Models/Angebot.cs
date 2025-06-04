namespace Backend.Models
{
    public class Angebot
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = string.Empty;
        public decimal Gesamtbetrag { get; set; }

        public Guid KundeId { get; set; }
        public virtual Kunde Kunde { get; set; } = new Kunde();

        public Guid MitarbeiterId { get; set; }
        public virtual Mitarbeiter Mitarbeiter { get; set; } = new Mitarbeiter();
    }
}
