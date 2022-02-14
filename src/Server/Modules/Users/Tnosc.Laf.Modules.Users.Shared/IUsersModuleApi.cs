using Tnosc.Laf.Modules.Users.Shared.Dtos;

namespace Tnosc.Laf.Modules.Users.Shared
{
    public interface IUsersModuleApi
    {
        Task<UserDto> GetUserAsync(Guid userId);
        Task<UserDto> GetUserAsync(string email);
    }
}
