using FluentValidation;

namespace UpKeep.Core.Identity.Tokens.Features.GenerateToken;

/// <summary>
///     Validator for the <see cref="GenerateTokenCommand" /> to ensure valid email and password input for token
///     generation.
/// </summary>
public class GenerateTokenCommandValidator : AbstractValidator<GenerateTokenCommand>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GenerateTokenCommandValidator" /> class and defines validation rules
    ///     for token generation.
    /// </summary>
    public GenerateTokenCommandValidator()
    {
        RuleFor(gtc => gtc.Email).Cascade(CascadeMode.Stop).NotEmpty().EmailAddress();
        RuleFor(gtc => gtc.Password).Cascade(CascadeMode.Stop).NotEmpty();
    }
}