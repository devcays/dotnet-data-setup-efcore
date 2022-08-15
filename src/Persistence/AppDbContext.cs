using Microsoft.EntityFrameworkCore;

namespace Persistence;

/**
 * Set up this class with the necessary properties and configurations.
 */
public class AppDbContext : DbContext
{
    /// <summary>
    ///  Don't delete this constructor. It's used by <see cref="AppContextDesignTimeDbFactory"/>.
    /// </summary>
    public AppDbContext(DbContextOptions options) : base(options) { }

    // Add properties here
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entities
    }
}