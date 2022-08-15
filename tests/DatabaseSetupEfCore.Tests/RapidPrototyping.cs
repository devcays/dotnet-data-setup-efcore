using System.Threading.Tasks;
using Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Xunit;

namespace DatabaseSetupEfCore.Tests;

/**
 * Use this test class for rapid prototyping.
 * 
 * It's useful to create separate test methods to try out different approaches and see if you
 * can query data from an actual MS-SQL database.
 */
public class RapidPrototyping
{
    private readonly IUserRepository repository;
    
    public RapidPrototyping()
    {
        IServiceCollection services = new ServiceCollection()
            .AddApplicationContext();
        ServiceProvider provider = services.BuildServiceProvider();
        repository = provider.GetRequiredService<IUserRepository>();
    }
    
    [Fact]
    public async Task CreateUserPrototyping()
    {
        // Your prototyping.
    }
    
    [Fact]
    public async Task QueryUserPrototyping()
    {
        // Your prototyping.
    }
}