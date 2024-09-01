using Microsoft.Extensions.DependencyInjection;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Repositories;

namespace OlehOlehNTT.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) => 
        services.AddScoped<IRepositoriAppUser, RepositoriAppUser>()
                .AddScoped<IRepositoriDeliveryMethod, RepositoriDeliveryMethod>();
}
