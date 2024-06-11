using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Transaction
{
    public int Id { get; set; }

    public int? PropertyId { get; set; }

    public int? TenantId { get; set; }

    public int? LeaseId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int TransactionTypeId { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public virtual Lease? Lease { get; set; }

    public virtual Property? Property { get; set; }

    public virtual Tenant? Tenant { get; set; }

    public virtual TransactionType TransactionType { get; set; } = null!;
}
