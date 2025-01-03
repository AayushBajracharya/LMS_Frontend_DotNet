﻿using System.Collections.Generic;
using System.Threading.Tasks;
 
using Frontend.Models;

namespace Presentation.Repositories
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(int id);
        Task<bool> AddTransactionAsync(TransactionDTO transaction);
        Task<bool> UpdateTransactionAsync(Transaction transaction);
        Task<bool> DeleteTransactionAsync(int id);
        Task<List<Transaction>> SearchTransactionsAsync(string search = "");
    }
}
