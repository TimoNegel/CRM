namespace Backend.Models
{
    public class Kunde
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public  string Firmenname { get; set; }
        public  string AnsprechpartnerVorname { get; set; }
        public  string AnsprechpartnerNachname { get; set; }
        public  string Tel { get; set; }
        public  string Email { get; set; }

        public Guid AdressId { get; set; }
        public virtual  Adresse Adresse { get; set; }

        // Navigation Properties
        public virtual ICollection<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
        public virtual ICollection<KontaktHistorie> KontaktHistorien { get; set; } = new List<KontaktHistorie>();
        public virtual ICollection<Angebot> Angebote { get; set; } = new List<Angebot>();
        public virtual ICollection<Rechnung> Rechnungen { get; set; } = new List<Rechnung>();
    }
}
