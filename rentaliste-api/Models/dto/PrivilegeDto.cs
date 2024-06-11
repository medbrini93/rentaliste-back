namespace rentaliste_api.Models.dto;

public class PrivilegeDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool ReadPropertyDate { get; set; }

    public bool WritePropertyData { get; set; }

    public bool ReadTransactions { get; set; }

    public bool WriteTransactions { get; set; }

    public bool ReadStaff { get; set; }

    public bool WriteStaff { get; set; }

    public bool ReadMaintenance { get; set; }

    public bool WriteMaintenanace { get; set; }

    public bool SendCommunications { get; set; }

    public bool ReadLease { get; set; }

    public bool WriteLease { get; set; }

    public virtual UserDto User { get; set; } = null!;
}