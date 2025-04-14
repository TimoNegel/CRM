namespace CRM.Models
{
    public class Auftrag
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
            public int State { get; set; }
        public double AuftragsValue { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual List<Service> Services { get; set; }
    }
}
