using System.ComponentModel.DataAnnotations;

namespace UpKeep.Core.Auth.Jwt;

/// <summary>
///     Options for configuring JWT authentication.
/// </summary>
public class JwtOptions : IValidatableObject
{
    /// <summary>
    ///     The secret key used to sign JWT tokens.
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    ///     The expiration time in minutes for JWT tokens.
    /// </summary>
    public int TokenExpirationInMinutes { get; set; } = 60;

    /// <summary>
    ///     The expiration time in days for refresh tokens.
    /// </summary>
    public int RefreshTokenExpirationInDays { get; set; } = 7;

    /// <summary>
    ///     Validates the JWT options.
    /// </summary>
    /// <param name="validationContext">The context information about the validation operation.</param>
    /// <returns>A collection of validation results.</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(Key))
            yield return new ValidationResult("JWT Key is required. Please update JwtSettings to include a JWT Key.");
    }
}