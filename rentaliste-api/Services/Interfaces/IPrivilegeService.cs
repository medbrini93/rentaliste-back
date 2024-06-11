using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IPrivilegeService
	{
        IEnumerable<PrivilegeDto> GetPrivileges();

        PrivilegeDto GetPrivilegeById(int id);

        PrivilegeDto GetPrivilegeByUserId(int userId);     

        bool AddPrivilege(PrivilegeDto privilegeDto);

        bool UpdatePrivilege(PrivilegeDto privilegeDto);

        bool DeletePrivilege(int id);
    }
}

