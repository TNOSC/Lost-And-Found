using Microsoft.Extensions.DependencyInjection;
using Tnosc.Laf.Modules.Users.ApplicationService.Contracts;
using Tnosc.Laf.Modules.Users.ApplicationService.Services;
using Tnosc.Laf.Modules.Users.Shared;

namespace Tnosc.Laf.Modules.Users.ApplicationService
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IUsersModuleApi, UsersModuleApi>();
            return services;
        }
    }
}