namespace UpKeep.Core.Identity.Tokens.Features.RefreshToken;

/// <summary>
///     Command for refreshing a JWT access token using an existing token and refresh token.
/// </summary>
/// <param name="Token">The expired or current JWT access token.</param>
/// <param name="RefreshToken">The refresh token used to obtain a new access token.</param>
public record RefreshTokenCommand(string Token, string RefreshToken);