using UpKeep.Core.Identity.Tokens.Features.GenerateToken;
using UpKeep.Core.Identity.Tokens.Features.RefreshToken;
using UpKeep.Core.Identity.Tokens.Models;

namespace UpKeep.Core.Identity.Tokens.Abstractions;

public interface ITokenService
{
    Task<TokenResponse> GenerateTokenAsync(GenerateTokenCommand command, string ipAddress, CancellationToken cancellationToken = default);
    Task<TokenResponse> RefreshTokenAsync(RefreshTokenCommand command, string ipAddress, CancellationToken cancellationToken = default);
}