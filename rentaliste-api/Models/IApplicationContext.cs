using Microsoft.EntityFrameworkCore;
using rentaliste_api.Models.db;

namespace rentaliste_api.Models
{
    public interface IApplicationContext
    {
         DbSet<Communication> Communications { get; set; }
         DbSet<CommunicationType> CommunicationTypes { get; set; }
         DbSet<Document> Documents { get; set; }
         DbSet<DocumentType> DocumentTypes { get; set; }
         DbSet<Lease> Leases { get; set; }
         DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }
         DbSet<MaintenanceType> MaintenanceTypes { get; set; }
         DbSet<Owner> Owners { get; set; }
         DbSet<Position> Positions { get; set; }
         DbSet<Privilege> Privileges { get; set; }
         DbSet<Property> Properties { get; set; }
         DbSet<PropertyType> PropertyTypes { get; set; }
         DbSet<Staff> Staffs { get; set; }
         DbSet<Tenant> Tenants { get; set; }
         DbSet<Transaction> Transactions { get; set; }
         DbSet<TransactionType> TransactionTypes { get; set; }
         DbSet<User> Users { get; set; }
    }
}