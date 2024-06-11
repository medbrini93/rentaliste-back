using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class PropertyType
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
