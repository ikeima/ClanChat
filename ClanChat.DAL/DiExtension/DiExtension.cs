using ClanChat.DAL.Repositories;
using ClanChat.Domain.Interfaces;
using ClanChat.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ClanChat.DAL.DiExtension
{
    public static class DiExtension
    {
        public static IServiceCollection AddApplications(this IServiceCollection services) 
        {
            return services
                .AddScoped<IRepository<User>, UsersRepository>()
                .AddScoped<IRepository<Clan>, ClanRepository>()
                .AddScoped<IRepository<Message>, MessageRepository>();
        }
    }
}
