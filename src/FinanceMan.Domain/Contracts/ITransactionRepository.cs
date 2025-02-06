namespace FinanceMan.Domain.Contracts;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    Task<List<Transaction>> GetTransactions(int id);
}
