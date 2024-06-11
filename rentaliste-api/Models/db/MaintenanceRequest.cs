using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class MaintenanceRequest
{
    public int Id { get; set; }

    public int PropertyId { get; set; }

    public int TenantId { get; set; }

    public DateTime RequestDate { get; set; }

    public int MaintenanceTypeId { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public int AssigneeId { get; set; }

    public virtual Staff Assignee { get; set; } = null!;

    public virtual MaintenanceType MaintenanceType { get; set; } = null!;

    public virtual Property Property { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
