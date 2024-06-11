namespace rentaliste_api.Models.dto;

public class PropertyDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int IdType { get; set; }

    public int Size { get; set; }

    public int OwnerId { get; set; }

    public string? Details { get; set; }

    public virtual PropertyTypeDto IdTypeNavigation { get; set; } = null!;

    public virtual OwnerDto Owner { get; set; } = null!;

}