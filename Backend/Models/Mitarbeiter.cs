namespace Backend.Models
{
    public class Mitarbeiter
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public  string Vorname { get; set; }
        public  string Nachname { get; set; }
        public  string Email { get; set; }
        public  string Telefonnummer { get; set; }

        public Guid AdressId { get; set; }
        public virtual  Adresse Adresse { get; set; }

        // Navigation Properties
        public virtual ICollection<KontaktHistorie> KontaktHistorien { get; set; } = new List<KontaktHistorie>();
        public virtual ICollection<Angebot> ErstellteAngebote { get; set; } = new List<Angebot>();
    }
}
