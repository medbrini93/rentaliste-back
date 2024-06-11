using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class MaintenanceType
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();
}
