using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IOwnerService
	{
        IEnumerable<OwnerDto> GetOwners();

        OwnerDto GetOwnerById(int id);

        OwnerDto GetOwnerByPhone(string phone);

        OwnerDto GetOwnerByEmailAddress(string emailAddress);

        bool AddOwner(OwnerDto documentDto);

        bool UpdateOwner(OwnerDto leaseDto);

        bool DeleteOwner(int id);
    }
}

