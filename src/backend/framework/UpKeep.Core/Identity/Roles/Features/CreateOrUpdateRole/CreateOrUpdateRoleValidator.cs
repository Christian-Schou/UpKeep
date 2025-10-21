using FluentValidation;

namespace UpKeep.Core.Identity.Roles.Features.CreateOrUpdateRole;

/// <summary>
///     Validator for the <see cref="CreateOrUpdateRoleCommand" /> to ensure role data integrity.
/// </summary>
public class CreateOrUpdateRoleValidator : AbstractValidator<CreateOrUpdateRoleCommand>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CreateOrUpdateRoleValidator" /> class and defines validation rules for
    ///     role creation or update.
    /// </summary>
    public CreateOrUpdateRoleValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Role name is required");
    }
}