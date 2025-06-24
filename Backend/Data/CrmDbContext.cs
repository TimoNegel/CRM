using Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data
{
    public class CrmDbContext(DbContextOptions<CrmDbContext> options) : IdentityDbContext<CrmUser>(options)
    {
        public DbSet<Adresse> Adressen { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Auftrag> Auftraege { get; set; }
        public DbSet<KontaktHistorie> KontaktHistorien { get; set; }
        public DbSet<Angebot> Angebote { get; set; }
        public DbSet<Rechnung> Rechnungen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adresse - Mitarbeiter (One-to-Many)
            modelBuilder.Entity<Mitarbeiter>()
                .HasOne(m => m.Adresse)
                .WithMany(a => a.Mitarbeiter)
                .HasForeignKey(m => m.AdressId)
                .OnDelete(DeleteBehavior.NoAction);

            // Adresse - Kunde (One-to-Many)
            modelBuilder.Entity<Kunde>()
                .HasOne(k => k.Adresse)
                .WithMany(a => a.Kunden)
                .HasForeignKey(k => k.AdressId)
                .OnDelete(DeleteBehavior.NoAction);

            // Kunde - Auftrag (One-to-Many)
            modelBuilder.Entity<Auftrag>()
                .HasOne(a => a.Kunde)
                .WithMany(k => k.Auftraege)
                .HasForeignKey(a => a.KundenId)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-Many zwischen Auftrag und Service
            modelBuilder.Entity<Auftrag>()
                .HasMany(a => a.Services)
                .WithMany(s => s.Auftraege);

            // Kunde - KontaktHistorie (One-to-Many)
            modelBuilder.Entity<KontaktHistorie>()
                .HasOne(kh => kh.Kunde)
                .WithMany(k => k.KontaktHistorien)
                .HasForeignKey(kh => kh.KundeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Mitarbeiter - KontaktHistorie (One-to-Many)
            modelBuilder.Entity<KontaktHistorie>()
                .HasOne(kh => kh.Mitarbeiter)
                .WithMany(m => m.KontaktHistorien)
                .HasForeignKey(kh => kh.MitarbeiterId)
                .OnDelete(DeleteBehavior.NoAction);

            // Angebot - Kunde (One-to-Many)
            modelBuilder.Entity<Angebot>()
                .HasOne(a => a.Kunde)
                .WithMany(k => k.Angebote)
                .HasForeignKey(a => a.KundeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Angebot - Mitarbeiter (One-to-Many)
            modelBuilder.Entity<Angebot>()
                .HasOne(a => a.Mitarbeiter)
                .WithMany(m => m.ErstellteAngebote)
                .HasForeignKey(a => a.MitarbeiterId)
                .OnDelete(DeleteBehavior.NoAction);

            // Rechnung - Auftrag (One-to-Many)
            modelBuilder.Entity<Rechnung>()
                .HasOne(r => r.Auftrag)
                .WithMany(a => a.Rechnungen)
                .HasForeignKey(r => r.AuftragId)
                .OnDelete(DeleteBehavior.NoAction);

            // Rechnung - Kunde (One-to-Many)
            modelBuilder.Entity<Rechnung>()
                .HasOne(r => r.Kunde)
                .WithMany(k => k.Rechnungen)
                .HasForeignKey(r => r.KundeId)
                .OnDelete(DeleteBehavior.NoAction);
        }


    }
}
