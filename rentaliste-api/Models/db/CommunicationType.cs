using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class CommunicationType
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<Communication> Communications { get; set; } = new List<Communication>();
}
