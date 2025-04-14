using CRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Mitarbeiter> Mitarbeiters { get; set; }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Adresse> Adressen { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Auftrag> Auftraege { get; set; }

        
    }
}
