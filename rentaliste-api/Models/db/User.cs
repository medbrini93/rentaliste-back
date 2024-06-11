using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class User
{
    public int Id { get; set; }

    public int StaffId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? Enabled { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Privilege> Privileges { get; set; } = new List<Privilege>();

    public virtual Staff Staff { get; set; } = null!;
}
