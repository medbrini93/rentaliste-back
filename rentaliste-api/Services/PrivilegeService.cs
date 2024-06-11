using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class PrivilegeService : IPrivilegeService
	{
		public PrivilegeService()
		{
		}

        public bool AddPrivilege(PrivilegeDto privilegeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeletePrivilege(int id)
        {
            throw new NotImplementedException();
        }

        public PrivilegeDto GetPrivilegeById(int id)
        {
            throw new NotImplementedException();
        }

        public PrivilegeDto GetPrivilegeByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrivilegeDto> GetPrivileges()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePrivilege(PrivilegeDto privilegeDto)
        {
            throw new NotImplementedException();
        }
    }
}

