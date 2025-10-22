namespace UpKeep.Core.Identity.Tokens.Models;

/// <summary>
///     Represents a response containing authentication and refresh tokens, including the refresh token's expiration time.
/// </summary>
/// <param name="Token">The JWT access token.</param>
/// <param name="RefreshToken">The refresh token used to obtain new access tokens.</param>
/// <param name="RefreshTokenExpiryTime">The expiration date and time of the refresh token.</param>
public record TokenResponse(string Token, string RefreshToken, DateTime RefreshTokenExpiryTime);