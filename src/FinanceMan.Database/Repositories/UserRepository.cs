using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Database.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User entity)
    {
        await dbContext.Users.AddAsync(entity);
        await dbContext.SaveChangesAsync();
        throw new NotImplementedException();
    }

    public async Task<bool> IsUser(int id)
        => await dbContext.Users.AnyAsync(x => x.Id == id);
}
