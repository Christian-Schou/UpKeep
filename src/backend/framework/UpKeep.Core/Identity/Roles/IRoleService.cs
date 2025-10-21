using UpKeep.Core.Identity.Roles.Features.CreateOrUpdateRole;
using UpKeep.Core.Identity.Roles.Features.UpdatePermissions;

namespace UpKeep.Core.Identity.Roles;

/// <summary>
///     Service interface for managing roles and their permissions in the system.
/// </summary>
public interface IRoleService
{
    /// <summary>
    ///     Asynchronously retrieves all roles.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains a collection of
    ///     <see cref="RoleDto" />.
    /// </returns>
    Task<IEnumerable<RoleDto>> GetAllRolesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Asynchronously retrieves a role by its unique identifier.
    /// </summary>
    /// <param name="roleId">The unique identifier of the role.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains the <see cref="RoleDto" /> if
    ///     found, otherwise null.
    /// </returns>
    Task<RoleDto?> GetRoleByIdAsync(string roleId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Asynchronously creates or updates a role.
    /// </summary>
    /// <param name="command">The command containing role details to create or update.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains the created or updated
    ///     <see cref="RoleDto" />.
    /// </returns>
    Task<RoleDto> CreateOrUpdateRoleAsync(CreateOrUpdateRoleCommand command,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Asynchronously deletes a role by its unique identifier.
    /// </summary>
    /// <param name="roleId">The unique identifier of the role to delete.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteRoleAsync(string roleId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Asynchronously updates the permissions for a role.
    /// </summary>
    /// <param name="command">The command containing the role ID and new permissions.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the role ID.</returns>
    Task<string> UpdatePermissionsAsync(UpdatePermissionsCommand command,
        CancellationToken cancellationToken = default);
}