namespace FinanceMan.Domain.Contracts;

public interface IGenericRepository<T>
{
    Task AddAsync(T entity);
}
