using System;
using rentaliste_api.Models;
using rentaliste_api.Models.db;
using rentaliste_api.Repository.Interfaces;


namespace rentaliste_api.Repository
{
	public class PropertyTypeRepository : GenericRepository<PropertyType> , IPropertyTypeRepository
	{
		public PropertyTypeRepository(ApplicationContext context)
			:base(context)
		{
		}
	}
}

