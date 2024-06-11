using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface ITransactionTypeService
	{
        IEnumerable<TransactionTypeDto> GetTransactionTypes();

        TransactionTypeDto GetTransactionTypeById(int id);

        TransactionTypeDto GetTransactionTypeByLabel(string label);

        bool AddTransactionType(TransactionTypeDto transactionTypeDto);

        bool UpdateTransactionType(TransactionTypeDto transactionTypeDto);

        bool DeleteTransactionType(int id);
    }
}

