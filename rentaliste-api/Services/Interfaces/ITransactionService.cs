using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ITransactionService
	{
        IEnumerable<TransactionDto> GetTransactions();

        IEnumerable<TransactionDto> GetTransactionsByPropertyId(int propertyId);

        IEnumerable<TransactionDto> GetTRansactionsByTenantId(int tenantId);

        IEnumerable<TransactionDto> GetTransactionsByLeaseId(int leaseId);

        IEnumerable<TransactionDto> GetTransactionsByType(int typeId);

        bool UpdateTransaction(TransactionDto transactionDto);

        bool DeleteTransaction(int id);
    }
}

