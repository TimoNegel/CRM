﻿namespace Backend.Models
{
    public class Auftrag
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal AuftragsValue { get; set; }
        public Guid KundenId { get; set; }
        public virtual Kunde Kunde { get; set; } = new Kunde();
        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string Position { get; set; } = string.Empty;

        // Many-to-Many mit Service
        public virtual ICollection<Service> Services { get; set; } = new List<Service>();

        // Navigation Property
        public virtual ICollection<Rechnung> Rechnungen { get; set; } = new List<Rechnung>();
    }
}