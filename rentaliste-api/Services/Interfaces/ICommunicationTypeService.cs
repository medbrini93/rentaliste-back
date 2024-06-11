using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ICommunicationTypeService
	{
		IEnumerable<CommunicationTypeDto> GetCommunicationTypes();

        CommunicationTypeDto GetCommunicationTypeById(int id);

        CommunicationTypeDto GetCommunicationTypeByLabel(string label);

        bool AddCommunicationType(CommunicationTypeDto communicationTypeDto);

        bool UpdateCommunicationType(CommunicationTypeDto communicationTypeDto);

        bool DeleteCommunicationType(int id);
    }
}

