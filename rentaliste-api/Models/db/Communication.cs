using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Communication
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int CommunicationTypeId { get; set; }

    public DateTime SendDate { get; set; }

    public string Message { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual CommunicationType CommunicationType { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
