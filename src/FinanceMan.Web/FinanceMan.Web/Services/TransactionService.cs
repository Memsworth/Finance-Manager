using Ardalis.Result;
using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using FinanceMan.Shared.Contracts;

namespace FinanceMan.Web.Services;

public class TransactionService(ITransactionRepository transactionRepository, IUserRepository userRepository) : ITransactionService
{
    //TODO:Rewrite the way how guard clauses are implemented in the services
    //Is the story being told is correct?
    //As an example, will the id ever be null?
    public async Task<List<Transaction>> GetTransactionsById(int userId)
    {
        return await transactionRepository.GetTransactions(userId);
    }
}