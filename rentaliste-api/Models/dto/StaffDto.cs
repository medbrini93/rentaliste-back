namespace rentaliste_api.Models.dto;

public class StaffDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? Address { get; set; }

    public int PositionId { get; set; }

    public virtual PositionDto Position { get; set; } = null!;

}