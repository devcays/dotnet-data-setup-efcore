using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence;


public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationContext(this IServiceCollection services)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
        services.AddDbContext<AppDbContext>(config =>
        {
            config.UseSqlServer(configuration.GetConnectionString("Sql"));
        });

        services.AddScoped<IUserRepository, EfUserRepository>();
        
        return services;
    }
}