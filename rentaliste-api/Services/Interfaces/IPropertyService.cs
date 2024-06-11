using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IPropertyService
	{
        IEnumerable<PropertyDto> GetMaintenanceTypes();

        PropertyDto GetPropertyById(int id);

        PropertyDto GetPropertyByName(string name);

        PropertyDto GetPropertyByAddress(string address);

        IEnumerable<PropertyDto> GetPropertiesBySize(int size);

        IEnumerable<PropertyDto> GetPropertiesByOwnerId(int ownerId);

        bool AddProperty(PropertyDto propertyDto);

        bool UpdateProperty(PropertyDto propertyDto);

        bool DeleteProperty(int id);
    }
}

