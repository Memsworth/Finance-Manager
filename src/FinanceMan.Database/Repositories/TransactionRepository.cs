using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;

namespace FinanceMan.Database.Repositories;

public class TransactionRepository : ITransactionRepository
{
    public Task AddAsync(Transaction entity)
    {
        throw new NotImplementedException();
    }
}
