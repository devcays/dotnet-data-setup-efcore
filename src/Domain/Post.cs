namespace Domain;

/// <summary>
/// Represents a post created by a user. Posts are always associated to a user.
/// </summary>
public class Post
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// A post title is required, and may not exceed 150 characters.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The post content does not have a maximum length, and may contain special characters such as æøå.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// The publish date may be null. Null denotes that the post is still a draft and isn't public yet.
    /// </summary>
    public DateTimeOffset? Published { get; set; }

    /// <summary>
    /// All the comments that users have written on the post.
    /// </summary>
    public List<Comment> Comments { get; set; }
}