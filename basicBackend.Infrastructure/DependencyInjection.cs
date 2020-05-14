using Microsoft.Extensions.DependencyInjection;
using basicBackend.Application.Interfaces;
using basicBackend.Infrastructure.Repositories;

namespace basicBackend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}