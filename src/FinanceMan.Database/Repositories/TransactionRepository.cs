using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Database.Repositories;

public class TransactionRepository(ApplicationDbContext dbContext) : ITransactionRepository
{
    public Task AddAsync(Transaction entity)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Transaction>> GetTransactions(int id)
    => await dbContext.Transactions.Where(x => x.Id == x.Id).ToListAsync();

        
}