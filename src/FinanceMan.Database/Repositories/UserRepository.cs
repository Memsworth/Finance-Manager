using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FinanceMan.Database.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsUser(int id)
        => await dbContext.Users.AnyAsync(x => x.Id == id);
}
