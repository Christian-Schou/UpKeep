namespace UpKeep.Core.Audit;

/// <summary>
///     Provides methods for retrieving audit trails related to users.
/// </summary>
public interface IAuditService
{
    /// <summary>
    ///     Asynchronously retrieves the audit trails for a specific user.
    /// </summary>
    /// <param name="userId">The unique identifier of the user.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains a list of
    ///     <see cref="AuditTrail" /> entries for the user.
    /// </returns>
    Task<List<AuditTrail>> GetUserTrailsAsync(Guid userId);
}