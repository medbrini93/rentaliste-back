using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IMaintenanceTypeService
	{

        IEnumerable<MaintenanceTypeDto> GetMaintenanceTypes();

        MaintenanceTypeDto GetMaintenanceTypeById(int id);

        MaintenanceTypeDto GetMaintenanceTypeByLabel(string label);

        bool AddMaintenanceType(MaintenanceTypeDto maintenanceTypeDto);

        bool UpdateMaintenanceType(MaintenanceTypeDto maintenanceTypeDto);

        bool DeleteMaintenanceType(int id);
    }
}

