using System.Net;

namespace UpKeep.Core.Exceptions;

/// <summary>
///     Represents a custom exception with support for error messages and HTTP status codes.
/// </summary>
public class CustomException : Exception
{
    /// <summary>
    ///     Gets the list of error messages associated with the exception.
    /// </summary>
    public List<string>? ErrorMessages { get; }

    /// <summary>
    ///     Gets the HTTP status code associated with the exception.
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CustomException" /> class with a specified error message, optional
    ///     error messages, and an HTTP status code.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="errors">The list of error messages associated with the exception.</param>
    /// <param name="statusCode">The HTTP status code associated with the exception. Defaults to InternalServerError.</param>
    public CustomException(string message, List<string>? errors = default,
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message)
    {
        ErrorMessages = errors;
        StatusCode = statusCode;
    }
}