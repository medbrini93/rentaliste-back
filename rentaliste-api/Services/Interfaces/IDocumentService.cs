using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IDocumentService
	{
        IEnumerable<DocumentDto> GetDocuments();

        DocumentDto GetDocumentById(int id);

        IEnumerable<DocumentDto> GetDocumentsByType(string type);

        IEnumerable<DocumentDto> GetDocumentsByLease(int leaseId);

        bool AddDocument(DocumentDto documentDto);

        bool UpdateDocument(DocumentDto leaseDto);

        bool DeleteDocument(int id);
    }
}

