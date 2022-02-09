using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class UserAppService : BaseAppService<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }

    }
}



