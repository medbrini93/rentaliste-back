using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;

namespace rentaliste_api.Services
{
    public class DocumentService : IDocumentService
	{
		public DocumentService()
		{
		}

        public bool AddDocument(DocumentDto documentDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDocument(int id)
        {
            throw new NotImplementedException();
        }

        public DocumentDto GetDocumentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentDto> GetDocuments()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentDto> GetDocumentsByLease(int leaseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentDto> GetDocumentsByType(string type)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDocument(DocumentDto leaseDto)
        {
            throw new NotImplementedException();
        }
    }
}

