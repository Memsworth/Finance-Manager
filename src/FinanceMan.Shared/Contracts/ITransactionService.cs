using FinanceMan.Domain;

namespace FinanceMan.Shared.Contracts;

public interface ITransactionService
{
    List<Transaction> GetTransactions();
}
