using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
      
    }
}
