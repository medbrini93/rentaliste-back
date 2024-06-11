using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IUserService
	{
        IEnumerable<UserDto> GetAllUsers();

        UserDto GetUserByUsername(string userName);

        UserDto GetUserById(int id);

        IEnumerable<UserDto> GetEnabledUsers();

        IEnumerable<UserDto> GetActiveUsers();

        bool ActivateUser(UserDto userDto);

        bool ToggleUserEnable(UserDto userDto);

        bool ToggleActiveUser(UserDto userDto);

        IEnumerable<UserDto> GetUsersByStaffId(int staffId);

        bool AddUser(UserDto documentDto);

        bool UpdateUser(UserDto leaseDto);

        bool UpdateUserPassword(UserDto leaseDto);

        bool DeleteUser(int id);
    }
}

