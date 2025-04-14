namespace CRM.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Aufwand { get; set; }
        public double Preis { get; set; }

    }
}
