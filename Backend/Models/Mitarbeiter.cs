namespace CRM.Models
{
    public class Mitarbeiter
    {
        public Guid Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public string Telefonnummer { get; set; }
        public virtual Adresse Adresse { get; set; }
    }
}
