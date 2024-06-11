namespace rentaliste_api.Models.dto;

public class TransactionDto
{
    public int Id { get; set; }

    public int? PropertyId { get; set; }

    public int? TenantId { get; set; }

    public int? LeaseId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int TransactionTypeId { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public virtual LeaseDto? Lease { get; set; }

    public virtual PropertyDto? Property { get; set; }

    public virtual TenantDto? Tenant { get; set; }
}