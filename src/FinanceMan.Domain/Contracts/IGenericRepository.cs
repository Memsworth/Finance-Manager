namespace FinanceMan.Domain.Contracts;

interface IGenericRepository<T>
{
    Task AddAsync(T entity);
}
