using System.ComponentModel;
using UpKeep.Shared.Authorization;

namespace UpKeep.Core.Identity.Tokens.Features.GenerateToken;

/// <summary>
///     Command for generating a JWT access token and refresh token using user credentials.
/// </summary>
/// <param name="Email">The email address of the user. Defaults to the admin email.</param>
/// <param name="Password">The password of the user. Defaults to the admin password.</param>
public record GenerateTokenCommand(
    [property: DefaultValue(ApplicationConstants.Admin.Email)]
    string Email,
    [property: DefaultValue(ApplicationConstants.Admin.Password)]
    string Password);