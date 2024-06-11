using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class OwnerService : IOwnerService
	{
		public OwnerService()
		{
		}

        public bool AddOwner(OwnerDto documentDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOwner(int id)
        {
            throw new NotImplementedException();
        }

        public OwnerDto GetOwnerByEmailAddress(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public OwnerDto GetOwnerById(int id)
        {
            throw new NotImplementedException();
        }

        public OwnerDto GetOwnerByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OwnerDto> GetOwners()
        {
            throw new NotImplementedException();
        }

        public bool UpdateOwner(OwnerDto leaseDto)
        {
            throw new NotImplementedException();
        }
    }
}

