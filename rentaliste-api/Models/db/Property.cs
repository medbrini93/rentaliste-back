using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Property
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int IdType { get; set; }

    public int Size { get; set; }

    public int OwnerId { get; set; }

    public string? Details { get; set; }

    public virtual PropertyType IdTypeNavigation { get; set; } = null!;

    public virtual ICollection<Lease> Leases { get; set; } = new List<Lease>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual Owner Owner { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
