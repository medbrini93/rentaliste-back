using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class DocumentType
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
