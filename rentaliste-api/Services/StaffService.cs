using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class StaffService : IStaffService
	{
		public StaffService()
		{
		}

        public bool AddStaff(StaffDto staffDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStaff(int id)
        {
            throw new NotImplementedException();
        }

        public StaffDto GetStaffByEmailAddress(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public StaffDto GetStaffByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffDto> GetStaffsByLastName(string lastname)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffDto> GetStaffsByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffDto> GetStaffsByPositionId(int positionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffDto> GettAllStaff()
        {
            throw new NotImplementedException();
        }

        public bool UpdateStaff(StaffDto staffDto)
        {
            throw new NotImplementedException();
        }
    }
}

