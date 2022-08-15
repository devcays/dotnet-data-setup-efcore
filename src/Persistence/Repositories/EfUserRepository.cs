using Domain;
using Domain.Abstractions;

namespace Persistence.Repositories;

internal class EfUserRepository : IUserRepository
{
    private readonly AppDbContext context;

    public EfUserRepository(AppDbContext context) 
        => this.context = context;

    /// <summary>
    /// This method should insert a new user in the database. If the user has related posts, then those should be
    /// persisted as well.
    /// </summary>
    public Task<bool> CreateUser(User user)
    {
        // Your implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method retrieves a user, its related posts and the associated comments for each post.
    /// </summary>
    public async Task<User?> GetUser(Guid userId)
    {
        // Your implementation here.
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<User> GetAll()
    {
        // Your implementation here.
        throw new NotImplementedException();
    }
}