using System;
using Microsoft.EntityFrameworkCore;
using rentaliste_api.Models.db;

namespace rentaliste_api.Models
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
		{
		}

        public DbSet<Communication> Communication { get; set; }
        public DbSet<CommunicationType> CommunicationType { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Lease> Lease { get; set; }
        public DbSet<MaintenanceRequest> MaintenanceRequest { get; set; }
        public DbSet<MaintenanceType> MaintenanceType { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<Property> Propertie { get; set; }
        public DbSet<PropertyType> PropertyType { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<User> User { get; set; }
    }
}

