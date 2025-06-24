namespace Backend.Models
{
    public class Pipeline
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; } = new Team();
        public virtual IEnumerable<Status> Stages { get; set; } = new List<Status>();
        public virtual IEnumerable<Auftrag> Auftraege { get; set; } = new List<Auftrag>();
    }
}
