using System.Net;

namespace UpKeep.Core.Exceptions;

/// <summary>
///     Exception thrown when an operation is unauthorized due to failed authentication.
/// </summary>
public class UnauthorizedException : UpKeepException
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="UnauthorizedException"/> class with a default authentication failed message.
    /// </summary>
    public UnauthorizedException() : base("authentication failed", [], HttpStatusCode.Unauthorized)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="UnauthorizedException"/> class with a custom message.
    /// </summary>
    /// <param name="message">The custom error message.</param>
    public UnauthorizedException(string message) : base(message, [], HttpStatusCode.Unauthorized)
    {
    }
}