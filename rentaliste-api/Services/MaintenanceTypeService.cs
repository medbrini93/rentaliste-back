using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class MaintenanceTypeService : IMaintenanceTypeService
	{
		public MaintenanceTypeService()
		{
		}

        public bool AddMaintenanceType(MaintenanceTypeDto maintenanceTypeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMaintenanceType(int id)
        {
            throw new NotImplementedException();
        }

        public MaintenanceTypeDto GetMaintenanceTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public MaintenanceTypeDto GetMaintenanceTypeByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintenanceTypeDto> GetMaintenanceTypes()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMaintenanceType(MaintenanceTypeDto maintenanceTypeDto)
        {
            throw new NotImplementedException();
        }
    }
}

