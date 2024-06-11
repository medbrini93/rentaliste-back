namespace rentaliste_api.Models.dto;

public class OwnerDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Address { get; set; } = null!;

}