namespace Domain.Abstractions;

/**
 * Part of task 4.
 * 
 * This interface is implemented in the Persistence project.
 */
public interface IUserRepository
{
    Task<bool> CreateUser(User user);
    Task<User?> GetUser(Guid userId);
    IAsyncEnumerable<User> GetAll();
}