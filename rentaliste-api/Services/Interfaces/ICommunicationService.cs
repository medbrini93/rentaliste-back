using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ICommunicationService
	{
        IEnumerable<CommunicationDto> GetCommunications();

        CommunicationDto GetCommunicationById(int id);

        IEnumerable<CommunicationDto> GetCommunicationsByStatus(string status);

        IEnumerable<CommunicationDto> GetCommunicationsByTenant(int tenantId);

        IEnumerable<CommunicationDto> GetCommunicationsByType(int communicationTypeId);

        bool AddCommunication(CommunicationDto communicationDto);

        bool UpdateCommunication(CommunicationDto communicationDto);

        bool DeleteCommunication(int id);
    }
}

