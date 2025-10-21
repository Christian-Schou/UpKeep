using System.Net;

namespace UpKeep.Core.Exceptions;

/// <summary>
///     Exception thrown when an operation is forbidden due to insufficient permissions.
/// </summary>
public class ForbiddenException : UpKeepException
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ForbiddenException" /> class with a default unauthorized message.
    /// </summary>
    public ForbiddenException() : base("unauthorized", [], HttpStatusCode.Forbidden)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ForbiddenException" /> class with a custom message.
    /// </summary>
    /// <param name="message">The custom error message.</param>
    public ForbiddenException(string message) : base(message, [], HttpStatusCode.Forbidden)
    {
    }
}