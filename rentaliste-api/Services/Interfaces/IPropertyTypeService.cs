using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IPropertyTypeService
	{
        IEnumerable<PropertyTypeDto> GetPropertyTypes();

        PropertyTypeDto GetPropertyTypeById(int id);

        PropertyTypeDto GetPropertyTypeByLabel(string label);

        bool AddPropertyType(PropertyTypeDto propertyTypeDto);

        bool UpdatePropertyType(PropertyTypeDto propertyTypeDto);

        bool DeletePropertyType(int id);
    }
}

