using Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Repositories;

namespace Data.Repositories
{
    public class RepositoryUser : RepositoryBase<Users>, IUserRepository
    {
    }
}
