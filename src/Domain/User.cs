namespace Domain;

/// <summary>
/// Represents an application user. Users are identified by their username, which must be unique.
/// Users may have zero or many posts.
/// </summary>
public class User
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// A username cannot be empty and may not exceed 50 characters.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// All the posts a user has written.
    /// </summary>
    public List<Post> Posts { get; set; }
}