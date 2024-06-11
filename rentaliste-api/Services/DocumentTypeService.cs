using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;
namespace rentaliste_api.Services
{
	public class DocumentTypeService : IDocumentTypeService
	{
		public DocumentTypeService()
		{
		}

        public bool AddDocumentType(DocumentTypeDto documentTypeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDocumentType(int id)
        {
            throw new NotImplementedException();
        }

        public DocumentTypeDto GetDocumentTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentTypeDto> GetDocumentTypes()
        {
            throw new NotImplementedException();
        }

        public DocumentTypeDto GetDocumentTypyByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDocumentType(DocumentTypeDto documentTypeDto)
        {
            throw new NotImplementedException();
        }
    }
}

