namespace UpKeep.Core.Identity.Roles.Features.CreateOrUpdateRole;

/// <summary>
///     Command for creating or updating a role with specified details.
/// </summary>
public class CreateOrUpdateRoleCommand
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
}