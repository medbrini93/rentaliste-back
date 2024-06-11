using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IDocumentTypeService
	{
        IEnumerable<DocumentTypeDto> GetDocumentTypes();

        DocumentTypeDto GetDocumentTypeById(int id);

        DocumentTypeDto GetDocumentTypyByLabel(string label);

        bool AddDocumentType(DocumentTypeDto documentTypeDto);

        bool UpdateDocumentType(DocumentTypeDto documentTypeDto);

        bool DeleteDocumentType(int id);
    }
}

