using FluentValidation;

namespace UpKeep.Core.Identity.Roles.Features.UpdatePermissions;

/// <summary>
///     Validator for the <see cref="UpdatePermissionsCommand" /> to ensure role permission data integrity.
/// </summary>
public class UpdatePermissionsValidator : AbstractValidator<UpdatePermissionsCommand>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="UpdatePermissionsValidator" /> class and defines validation rules for
    ///     updating role permissions.
    /// </summary>
    public UpdatePermissionsValidator()
    {
        RuleFor(upc => upc.RoleId).NotEmpty();
        RuleFor(upc => upc.Permissions).NotNull();
    }
}