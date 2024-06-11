using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class PropertyService : IPropertyService
	{
		public PropertyService()
		{
		}

        public bool AddProperty(PropertyDto propertyDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProperty(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PropertyDto> GetMaintenanceTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PropertyDto> GetPropertiesByOwnerId(int ownerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PropertyDto> GetPropertiesBySize(int size)
        {
            throw new NotImplementedException();
        }

        public PropertyDto GetPropertyByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public PropertyDto GetPropertyById(int id)
        {
            throw new NotImplementedException();
        }

        public PropertyDto GetPropertyByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProperty(PropertyDto propertyDto)
        {
            throw new NotImplementedException();
        }
    }
}

