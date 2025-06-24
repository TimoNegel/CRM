using CRM.Data;

namespace Backend.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual Pipeline? Pipeline { get; set; }

        // Navigation Properties
        public virtual List<CrmUser> Members { get; set; } = new();
    }
}
