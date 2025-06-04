namespace Backend.Models
{
    public class KontaktHistorie
    {
        public Guid Id { get; set; }
        public DateTime Datum { get; set; }
        public  string Typ { get; set; }
        public  string Notizen { get; set; }
        public Guid KundeId { get; set; }
        public virtual  Kunde Kunde { get; set; }
        public Guid MitarbeiterId { get; set; }
        public virtual  Mitarbeiter Mitarbeiter { get; set; }
    }
}
