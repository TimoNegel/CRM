namespace Backend.Models
{
    public class Rechnung
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public decimal Betrag { get; set; }
        public string Zahlungsstatus { get; set; } = string.Empty;
        public DateTime? Zahlungsdatum { get; set; }

        public Guid AuftragId { get; set; }
        public virtual  Auftrag Auftrag { get; set; } = new Auftrag();

        public Guid KundeId { get; set; }
        public virtual Kunde Kunde { get; set; } = new Kunde();
    }
}
