using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using FinanceMan.Shared.Contracts;

namespace FinanceMan.Web.Services;

public class TransactionService(ITransactionRepository transactionRepository) : ITransactionService
{
    public List<Transaction> GetTransactions()
    {
        throw new NotImplementedException();
    }
}