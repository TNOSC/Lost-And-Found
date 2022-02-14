using Tnosc.Laf.Modules.Users.ApplicationService.Contracts;
using Tnosc.Laf.Modules.Users.Shared;
using Tnosc.Laf.Modules.Users.Shared.Dtos;

namespace Tnosc.Laf.Modules.Users.ApplicationService.Services
{
    internal sealed class UsersModuleApi : IUsersModuleApi
    {
        private readonly IUsersService _usersService;

        public UsersModuleApi(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public Task<UserDto> GetUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
