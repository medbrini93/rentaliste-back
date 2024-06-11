using System;
using System.Collections.Generic;

namespace rentaliste_api.Models.db;

public partial class TransactionType
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
