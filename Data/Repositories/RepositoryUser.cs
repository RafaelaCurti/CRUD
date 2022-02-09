using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class RepositoryUser : RepositoryBase<User>, IUserRepository
    {
    }
}
