namespace rentaliste_api.Models.dto;

public class MaintenanceRequestDto
{
    public int Id { get; set; }

    public int PropertyId { get; set; }

    public int TenantId { get; set; }

    public DateTime RequestDate { get; set; }

    public int MaintenanceTypeId { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public int AssigneeId { get; set; }

    public virtual StaffDto Assignee { get; set; } = null!;

    public virtual MaintenanceTypeDto MaintenanceType { get; set; } = null!;

    public virtual PropertyDto Property { get; set; } = null!;

    public virtual TenantDto Tenant { get; set; } = null!;
}