namespace Backend.Models
{
    public class Mitarbeiter
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefonnummer { get; set; } = string.Empty;

        public Guid AdressId { get; set; }
        public virtual Adresse Adresse { get; set; } = new Adresse();

        // Navigation Properties
        public virtual ICollection<KontaktHistorie> KontaktHistorien { get; set; } = new List<KontaktHistorie>();
        public virtual ICollection<Angebot> ErstellteAngebote { get; set; } = new List<Angebot>();
    }
}
