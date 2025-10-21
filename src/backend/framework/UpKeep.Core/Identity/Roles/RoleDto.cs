namespace UpKeep.Core.Identity.Roles;

/// <summary>
///     Data transfer object representing a role and its associated permissions.
/// </summary>
public class RoleDto
{
    /// <summary>
    ///     Gets or sets the unique identifier of the role.
    /// </summary>
    public string Id { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the name of the role.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the description of the role.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    ///     Gets or sets the list of permissions associated with the role.
    /// </summary>
    public List<string>? Permissions { get; set; }
}