namespace rentaliste_api.Models.dto;

public class LeaseDto
{
    public int Id { get; set; }

    public int IdProperty { get; set; }

    public int IdTenant { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal MonthlyRent { get; set; }

    public decimal DepositAmount { get; set; }

    public string? LeaseTerms { get; set; }

    public virtual PropertyDto IdPropertyNavigation { get; set; } = null!;

    public virtual TenantDto IdTenantNavigation { get; set; } = null!;

}