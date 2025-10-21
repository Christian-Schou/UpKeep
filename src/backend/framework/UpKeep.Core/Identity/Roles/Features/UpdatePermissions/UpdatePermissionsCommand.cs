namespace UpKeep.Core.Identity.Roles.Features.UpdatePermissions;

/// <summary>
///     Command for updating the permissions associated with a specific role.
/// </summary>
public class UpdatePermissionsCommand
{
    /// <summary>
    ///     Gets or sets the unique identifier of the role to update.
    /// </summary>
    public string RoleId { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the list of permissions to assign to the role.
    /// </summary>
    public List<string> Permissions { get; set; } = default!;
}