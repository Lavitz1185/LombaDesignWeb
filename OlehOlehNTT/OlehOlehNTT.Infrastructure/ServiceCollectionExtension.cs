using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;
using OlehOlehNTT.Infrastructure.Repositories;

namespace OlehOlehNTT.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") 
            ?? throw new InvalidOperationException("Connection 'DefaultConnection' tidak ditemukan");

        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));
        services.AddScoped<IRepositoriAppUser, RepositoriAppUser>();
        services.AddScoped<IRepositoriDeliveryMethod, RepositoriDeliveryMethod>();
        services.AddScoped<IRepositoriProduk, RepositoriProduk>();
        services.AddScoped<IRepositoriKategoriProduk, RepositoriKategoriProduk>();

        return services;
    }
}
