namespace Backend.Models
{
    public class KontaktHistorie
    {
        public Guid Id { get; set; }
        public DateTime Datum { get; set; }
        public string Typ { get; set; } = string.Empty;
        public string Notizen { get; set; } = string.Empty;
        public Guid KundeId { get; set; }
        public virtual Kunde Kunde { get; set; } = new Kunde();
        public Guid MitarbeiterId { get; set; }
        public virtual Mitarbeiter Mitarbeiter { get; set; } = new Mitarbeiter();
    }
}
