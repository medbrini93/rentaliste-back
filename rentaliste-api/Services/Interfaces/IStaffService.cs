using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IStaffService
	{
        IEnumerable<StaffDto> GettAllStaff();

        IEnumerable<StaffDto> GetStaffsByName(string name);

        IEnumerable<StaffDto> GetStaffsByLastName(string lastname);

        IEnumerable<StaffDto> GetStaffsByPositionId(int positionId);

        StaffDto GetStaffByEmailAddress(string emailAddress);

        StaffDto GetStaffByPhone(string phone);

        bool AddStaff(StaffDto staffDto);

        bool UpdateStaff(StaffDto staffDto);

        bool DeleteStaff(int id);
    }
}

