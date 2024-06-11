using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class TransactionTypeService : ITransactionTypeService
	{
		public TransactionTypeService()
		{
		}

        public bool AddTransactionType(TransactionTypeDto transactionTypeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTransactionType(int id)
        {
            throw new NotImplementedException();
        }

        public TransactionTypeDto GetTransactionTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public TransactionTypeDto GetTransactionTypeByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionTypeDto> GetTransactionTypes()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTransactionType(TransactionTypeDto transactionTypeDto)
        {
            throw new NotImplementedException();
        }
    }
}

