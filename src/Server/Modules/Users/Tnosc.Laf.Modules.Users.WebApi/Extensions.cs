using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Tnosc.Laf.Modules.Users.ApplicationService;

namespace Tnosc.Laf.Modules.Users.WebApi
{
    public static class Extensions
    {
        public static IServiceCollection AddUsersModule(this IServiceCollection services)
        {
            services.AddApplicationLayer();
            return services;
        }

        public static IApplicationBuilder UseUsersModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
