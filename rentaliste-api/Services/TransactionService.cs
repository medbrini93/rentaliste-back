using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class TransactionService : ITransactionService
	{
		public TransactionService()
		{
		}

        public bool DeleteTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionDto> GetTransactions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionDto> GetTransactionsByLeaseId(int leaseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionDto> GetTransactionsByPropertyId(int propertyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionDto> GetTRansactionsByTenantId(int tenantId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionDto> GetTransactionsByType(int typeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTransaction(TransactionDto transactionDto)
        {
            throw new NotImplementedException();
        }
    }
}

