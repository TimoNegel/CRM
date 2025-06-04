namespace Backend.Models
{
    public class Adresse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string PLZ { get; set; } = string.Empty; 
        public string Strasse { get; set; } = string.Empty;
        public string Hausnummer { get; set; } = string.Empty;
        public string Ort { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;

        // Navigation Properties für Beziehungen
        public virtual ICollection<Mitarbeiter> Mitarbeiter { get; set; } = new List<Mitarbeiter>();
        public virtual ICollection<Kunde> Kunden { get; set; } = new List<Kunde>();
    }
}
