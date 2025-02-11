namespace FinanceMan.Domain.Contracts;

public interface IUserRepository : IGenericRepository<User>
{
    Task<bool> IsUserAsync(int id);
}
