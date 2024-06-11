using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Tenant
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public virtual ICollection<Communication> Communications { get; set; } = new List<Communication>();

    public virtual ICollection<Lease> Leases { get; set; } = new List<Lease>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
