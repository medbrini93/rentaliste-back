using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ILeaseService
	{
        IEnumerable<LeaseDto> GetLeases();

        LeaseDto GetLeaseById(int id);

        IEnumerable<LeaseDto> GetLeasesByTenant(int tenantId);

        IEnumerable<LeaseDto> GetLeasesByProperty(int propertyId);

        bool AddLease(LeaseDto leaseDto);

        bool UpdateLease(LeaseDto leaseDto);

        bool DeleteLease(int id);
    }
}

