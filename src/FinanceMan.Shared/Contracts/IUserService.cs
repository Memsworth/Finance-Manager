using Ardalis.Result;
using FinanceMan.Shared.Dtos;

namespace FinanceMan.Shared.Contracts;

public interface IUserService
{
    public Task<Result> CreateUser(CreateUserDto userDto);
}
