using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class MaintenanceRequestService : IMaintenanceRequestService
	{
		public MaintenanceRequestService()
		{
		}

        public bool AddMaintenanceRequest(MaintenanceRequestDto maintenanceRequestDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMaintenanceRequest(int id)
        {
            throw new NotImplementedException();
        }

        public MaintenanceRequestDto GetMaintenanceRequestById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintenanceRequestDto> GetMaintenanceRequests()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByProperty(int propertyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByTenant(int tenantId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintenanceRequestDto> GetmaintenanceRequestsByType(int typeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMaintenanceRequest(MaintenanceRequestDto maintenanceRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}

