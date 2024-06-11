using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;

namespace rentaliste_api.Services
{
	public class CommunicationService : ICommunicationService
	{
		public CommunicationService()
		{
		}

        public bool AddCommunication(CommunicationDto communicationDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommunication(int id)
        {
            throw new NotImplementedException();
        }

        public CommunicationDto GetCommunicationById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommunicationDto> GetCommunications()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommunicationDto> GetCommunicationsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommunicationDto> GetCommunicationsByTenant(int tenantId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommunicationDto> GetCommunicationsByType(int communicationTypeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCommunication(CommunicationDto communicationDto)
        {
            throw new NotImplementedException();
        }
    }
}

