using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Lease
{
    public int Id { get; set; }

    public int IdProperty { get; set; }

    public int IdTenant { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal MonthlyRent { get; set; }

    public decimal DepositAmount { get; set; }

    public string? LeaseTerms { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual Property IdPropertyNavigation { get; set; } = null!;

    public virtual Tenant IdTenantNavigation { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
