using Microsoft.Extensions.DependencyInjection;

namespace ClanChat.DAL.DiExtension
{
    public static class DiExtension
    {
        public static IServiceCollection AddApplications(this IServiceCollection services)
        {
            return services;
        }
    }
}
