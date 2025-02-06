using Ardalis.Result;
using FinanceMan.Domain;
using FinanceMan.Domain.Contracts;
using FinanceMan.Shared.Contracts;
using FinanceMan.Shared.Dtos;

namespace FinanceMan.Web.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<Result> CreateUser(CreateUserDto userDto)
    {
        var user = new User
        {
            Balance = decimal.Zero,
            LastUpdate = DateTime.UtcNow,
        };

        await userRepository.AddAsync(user);
        return Result.Success();
    }
}
