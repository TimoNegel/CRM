namespace Backend.Models
{
    public class Kunde
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Firmenname { get; set; } = string.Empty;
        public string AnsprechpartnerVorname { get; set; } = string.Empty;
        public string AnsprechpartnerNachname { get; set; } = string.Empty;
        public string Tel { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Guid AdressId { get; set; }
        public virtual Adresse Adresse { get; set; } = new Adresse();

        // Navigation Properties
        public virtual ICollection<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
        public virtual ICollection<Rechnung> Rechnungen { get; set; } = new List<Rechnung>();
    }
}
