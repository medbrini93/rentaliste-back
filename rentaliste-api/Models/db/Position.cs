using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Position
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
