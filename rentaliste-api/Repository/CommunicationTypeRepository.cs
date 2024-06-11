using System;
using rentaliste_api.Models;
using rentaliste_api.Models.db;
using rentaliste_api.Repository.Interfaces;


namespace rentaliste_api.Repository
{
    public class CommunicationTypeRepository : GenericRepository<CommunicationType>,ICommunicationTypeRepository
	{
        public CommunicationTypeRepository(ApplicationContext context) : base(context)
        {
        }

    }
}

