namespace CRM.Models
{
    public class Kunde
    {
        public Guid Id { get; set; }
        public string Firmenname { get; set; }
        public string Ansprechpartner { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }
        public virtual Adresse Adresse { get; set; }
    }
}
