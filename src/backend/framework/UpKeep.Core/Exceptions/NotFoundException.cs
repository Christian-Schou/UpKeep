using System.Net;

namespace UpKeep.Core.Exceptions;

/// <summary>
///     Exception thrown when a requested resource is not found.
/// </summary>
public class NotFoundException(string message)
    : UpKeepException(message, [], HttpStatusCode.NotFound);