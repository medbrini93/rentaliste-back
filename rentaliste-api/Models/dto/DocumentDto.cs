namespace rentaliste_api.Models.dto;

public class DocumentDto
{
    public int Id { get; set; }

    public int DocumentTypeId { get; set; }

    public string? Description { get; set; }

    public string Link { get; set; } = null!;

    public int LeaseId { get; set; }

    public virtual DocumentTypeDto DocumentType { get; set; } = null!;

    public virtual LeaseDto Lease { get; set; } = null!;
}