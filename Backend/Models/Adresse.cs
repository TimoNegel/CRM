namespace Backend.Models
{
    public class Adresse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public  string PLZ { get; set; }
        public  string Strasse { get; set; }
        public  string Hausnummer { get; set; }
        public  string Ort { get; set; }
        public  string Land { get; set; }

        // Navigation Properties für Beziehungen
        public virtual ICollection<Mitarbeiter> Mitarbeiter { get; set; } = new List<Mitarbeiter>();
        public virtual ICollection<Kunde> Kunden { get; set; } = new List<Kunde>();
    }
}
