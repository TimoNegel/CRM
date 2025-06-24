using Backend.Models;
using Microsoft.AspNetCore.Identity;

namespace CRM.Data
{
    public class CrmUser : IdentityUser
    {
        public Guid IdGuid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefonnummer { get; set; } = string.Empty;

        public Guid AdressId { get; set; }
        public virtual Adresse Adresse { get; set; } = new Adresse();
        public virtual Team Team { get; set; } = new Team();
    }

}
