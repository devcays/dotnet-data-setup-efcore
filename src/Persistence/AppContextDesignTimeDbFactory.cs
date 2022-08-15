using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Persistence;

/// <summary>
/// This class enables you to run dotnet-ef commands against the Persistence project.
/// </summary>
public class AppContextDesignTimeDbFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
        
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder()
            .UseSqlServer(config.GetConnectionString("Sql"))
            .Options;
        
        return new AppDbContext(dbContextOptions);
    }
}