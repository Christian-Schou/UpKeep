using System.Net;

namespace UpKeep.Core.Exceptions;

/// <summary>
///     Represents a custom exception for the UpKeep application, supporting error messages and HTTP status codes.
/// </summary>
public class UpKeepException : Exception
{
    /// <summary>
    ///     Gets the collection of error messages associated with the exception.
    /// </summary>
    public IEnumerable<string> ErrorMessages { get; }

    /// <summary>
    ///     Gets the HTTP status code associated with the exception.
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    /// <summary>
    ///     Initializes a new instance of the <see cref="UpKeepException" /> class with a specified error message, error
    ///     messages, and HTTP status code.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="errors">The collection of error messages associated with the exception.</param>
    /// <param name="statusCode">The HTTP status code associated with the exception. Defaults to InternalServerError.</param>
    public UpKeepException(string message, IEnumerable<string> errors,
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message)
    {
        ErrorMessages = errors;
        StatusCode = statusCode;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="UpKeepException" /> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public UpKeepException(string message) : base(message)
    {
        ErrorMessages = new List<string>();
    }
}