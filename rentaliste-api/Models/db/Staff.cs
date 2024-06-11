using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Staff
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? Address { get; set; }

    public int PositionId { get; set; }

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
