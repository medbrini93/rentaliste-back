namespace rentaliste_api.Models.dto;

public partial class CommunicationDto
{
    public int Id { get; set; }
    
    public int TenantId { get; set; }

    public int CommunicationTypeId { get; set; }

    public DateTime SendDate { get; set; }

    public string Message { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual CommunicationTypeDto CommunicationType { get; set; } = null!;

    public virtual TenantDto Tenant { get; set; } = null!;
}