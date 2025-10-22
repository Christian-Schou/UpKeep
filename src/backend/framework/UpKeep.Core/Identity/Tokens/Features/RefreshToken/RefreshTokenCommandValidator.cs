using FluentValidation;

namespace UpKeep.Core.Identity.Tokens.Features.RefreshToken;

/// <summary>
///     Validator for the <see cref="RefreshTokenCommand" /> to ensure valid token and refresh token input for refreshing
///     JWT tokens.
/// </summary>
public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RefreshTokenCommandValidator" /> class and defines validation rules
    ///     for refreshing tokens.
    /// </summary>
    public RefreshTokenCommandValidator()
    {
        RuleFor(rtc => rtc.Token).Cascade(CascadeMode.Stop).NotEmpty();
        RuleFor(rtc => rtc.RefreshToken).Cascade(CascadeMode.Stop).NotEmpty();
    }
}