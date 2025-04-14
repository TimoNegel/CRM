namespace CRM.Models
{
    public class Adresse
    {
        public Guid Id { get; set; }
        public string PLZ { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string Ort {  get; set; }
        public string Land { get; set; }
    }
}
