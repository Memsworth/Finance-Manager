using FinanceMan.Domain;

namespace FinanceMan.Shared.Contracts;

public interface ITransactionService
{
    Task<List<Transaction>> GetTransactionsById(int userId);
}
