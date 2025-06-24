using Backend.Models;
using CRM.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class CrmDbContext(DbContextOptions<CrmDbContext> options) : IdentityDbContext<CrmUser>(options)
{
    public DbSet<Adresse> Adressen { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Kunde> Kunden { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Auftrag> Auftraege { get; set; }
    public DbSet<Rechnung> Rechnungen { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Pipeline> Pipelines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Adresse - Kunde (One-to-Many)
        modelBuilder.Entity<Kunde>()
            .HasOne(k => k.Adresse)
            .WithMany(a => a.Kunden)
            .HasForeignKey(k => k.AdressId)
            .OnDelete(DeleteBehavior.NoAction);

        // Adresse - CrmUser (One-to-Many)
        modelBuilder.Entity<CrmUser>()
            .HasOne(u => u.Adresse)
            .WithMany()
            .HasForeignKey(u => u.AdressId)
            .OnDelete(DeleteBehavior.NoAction);

        // Kunde - Auftrag (One-to-Many)
        modelBuilder.Entity<Auftrag>()
            .HasOne(a => a.Kunde)
            .WithMany(k => k.Auftraege)
            .HasForeignKey(a => a.KundenId)
            .OnDelete(DeleteBehavior.NoAction);

        // Auftrag - Service (Many-to-Many)
        modelBuilder.Entity<Auftrag>()
            .HasMany(a => a.Services)
            .WithMany(s => s.Auftraege);

        // Auftrag - Rechnung (One-to-Many)
        modelBuilder.Entity<Rechnung>()
            .HasOne(r => r.Auftrag)
            .WithMany(a => a.Rechnungen)
            .HasForeignKey(r => r.AuftragId)
            .OnDelete(DeleteBehavior.NoAction);

        // Kunde - Rechnung (One-to-Many)
        modelBuilder.Entity<Rechnung>()
            .HasOne(r => r.Kunde)
            .WithMany(k => k.Rechnungen)
            .HasForeignKey(r => r.KundeId)
            .OnDelete(DeleteBehavior.NoAction);

        // Status - Auftrag (One-to-Many)
        modelBuilder.Entity<Status>()
            .HasMany(s => s.Auftraege)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);

        // Team - CrmUser (One-to-Many)
        modelBuilder.Entity<Team>()
            .HasMany(t => t.Members)
            .WithOne(u => u.Team)
            .OnDelete(DeleteBehavior.NoAction);

        // Team - Pipeline (One-to-One)
        modelBuilder.Entity<Team>()
            .HasOne(t => t.Pipeline)
            .WithOne(p => p.Team)
            .HasForeignKey<Pipeline>(p => p.TeamId)
            .OnDelete(DeleteBehavior.NoAction);

        // Pipeline - Status (Stages, One-to-Many)
        modelBuilder.Entity<Pipeline>()
            .HasMany(p => p.Stages)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);

        // Pipeline - Auftrag (One-to-Many)
        modelBuilder.Entity<Pipeline>()
            .HasMany(p => p.Auftraege)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);
    }
}