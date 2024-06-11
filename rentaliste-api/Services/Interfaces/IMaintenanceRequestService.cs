using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IMaintenanceRequestService
	{
        IEnumerable<MaintenanceRequestDto> GetMaintenanceRequests();

        MaintenanceRequestDto GetMaintenanceRequestById(int id);

        IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByTenant(int tenantId);

        IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByType(int typeId);

        IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByProperty(int propertyId);

        bool AddMaintenanceRequest(MaintenanceRequestDto maintenanceRequestDto);

        bool UpdateMaintenanceRequest(MaintenanceRequestDto maintenanceRequestDto);

        bool DeleteMaintenanceRequest(int id);
    }
}

