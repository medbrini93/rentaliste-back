using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;

namespace rentaliste_api.Services
{
	public class LeaseService : ILeaseService
	{
		public LeaseService()
		{
		}

        public bool AddLease(LeaseDto leaseDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLease(int id)
        {
            throw new NotImplementedException();
        }

        public LeaseDto GetLeaseById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeaseDto> GetLeases()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeaseDto> GetLeasesByProperty(int propertyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeaseDto> GetLeasesByTenant(int tenantId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLease(LeaseDto leaseDto)
        {
            throw new NotImplementedException();
        }
    }
}

