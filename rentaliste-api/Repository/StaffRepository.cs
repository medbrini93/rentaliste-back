using System;
using rentaliste_api.Models;
using rentaliste_api.Models.db;
using rentaliste_api.Repository.Interfaces;
namespace rentaliste_api.Repository
{
	public class StaffRepository : GenericRepository<Staff> , IStaffRepository
	{
		public StaffRepository(ApplicationContext context)
			:base(context)
		{
		}
	}
}

