using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class UserService : IUserService
	{
		public UserService()
		{
			
		}

        public bool ActivateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public bool AddUser(UserDto documentDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetActiveUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetEnabledUsers()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserByUsername(string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsersByStaffId(int staffId)
        {
            throw new NotImplementedException();
        }

        public bool ToggleActiveUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public bool ToggleUserEnable(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserDto leaseDto)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserPassword(UserDto leaseDto)
        {
            throw new NotImplementedException();
        }
    }
}

