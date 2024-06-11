using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class PropertyTypeService : IPropertyTypeService
	{
		public PropertyTypeService()
		{
		}

        public bool AddPropertyType(PropertyTypeDto propertyTypeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeletePropertyType(int id)
        {
            throw new NotImplementedException();
        }

        public PropertyTypeDto GetPropertyTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public PropertyTypeDto GetPropertyTypeByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PropertyTypeDto> GetPropertyTypes()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePropertyType(PropertyTypeDto propertyTypeDto)
        {
            throw new NotImplementedException();
        }
    }
}

