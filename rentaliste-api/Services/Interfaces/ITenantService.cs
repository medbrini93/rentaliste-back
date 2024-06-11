using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ITenantService
	{
        IEnumerable<TenantDto> GetTenants();

        TenantDto GetTenantById(int id);

        TenantDto GetTenantByPhone(string phone);

        TenantDto GetTenantByEmailAddress(string emailAddress);

        bool AddTenant(TenantDto tenantDto);

        bool UpdateTenant(TenantDto tenantDto);

        bool DeleteTenant(int id);
    }
}

