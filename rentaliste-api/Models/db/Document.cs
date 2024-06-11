using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class Document
{
    public int Id { get; set; }

    public int DocumentTypeId { get; set; }

    public string? Description { get; set; }

    public string Link { get; set; } = null!;

    public int LeaseId { get; set; }

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual Lease Lease { get; set; } = null!;
}
