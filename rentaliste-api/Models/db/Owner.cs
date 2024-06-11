using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Owner
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
