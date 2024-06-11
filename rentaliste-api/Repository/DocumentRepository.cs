using System;
using rentaliste_api.Models;
using rentaliste_api.Models.db;
using rentaliste_api.Repository.Interfaces;

namespace rentaliste_api.Repository
{
    public class DocumentRepository : GenericRepository<Document> , IDocumentRepository

	{
        public DocumentRepository(ApplicationContext context) : base(context)
		{
		}
	}
}

