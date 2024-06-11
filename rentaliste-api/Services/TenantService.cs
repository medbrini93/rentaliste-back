using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class TenantService : ITenantService
	{
		public TenantService()
		{
		}

        public bool AddTenant(TenantDto tenantDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTenant(int id)
        {
            throw new NotImplementedException();
        }

        public TenantDto GetTenantByEmailAddress(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public TenantDto GetTenantById(int id)
        {
            throw new NotImplementedException();
        }

        public TenantDto GetTenantByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TenantDto> GetTenants()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTenant(TenantDto tenantDto)
        {
            throw new NotImplementedException();
        }
    }
}

