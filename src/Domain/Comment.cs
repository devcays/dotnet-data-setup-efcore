namespace Domain;

/// <summary>
/// Represents a comment that a user can write on a post.
/// </summary>
public class Comment
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// The text that a comment author has written on a post. This cannot be empty and may not exceed 2000 characters.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The date when the comment was written.
    /// </summary>
    public DateTimeOffset Published { get; set; }

    /// <summary>
    /// A comment author is the user that commented on a post.
    /// </summary>
    public User Author { get; set; }
}