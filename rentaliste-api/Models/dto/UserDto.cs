namespace rentaliste_api.Models.dto;

public class UserDto
{
    public int Id { get; set; }

    public int StaffId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? Enabled { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual StaffDto Staff { get; set; } = null!;
}