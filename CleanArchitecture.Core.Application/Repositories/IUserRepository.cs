using CleanArchitecture.Core.Domain.Entities;

namespace CleanArchitecture.Core.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellation);
}
