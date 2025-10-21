namespace UpKeep.Core.Audit;

/// <summary>
///     Represents an audit trail entry for tracking changes made to entities in the system.
/// </summary>
public class AuditTrail
{
    /// <summary>
    ///     Gets or sets the unique identifier for the audit trail entry.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who performed the operation.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    ///     Gets or sets the type of operation performed (e.g., Create, Update, Delete).
    /// </summary>
    public string? Operation { get; set; }

    /// <summary>
    ///     Gets or sets the name of the entity affected by the operation.
    /// </summary>
    public string? Entity { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the operation occurred.
    /// </summary>
    public DateTimeOffset DateTime { get; set; }

    /// <summary>
    ///     Gets or sets the previous values of the entity before the operation.
    /// </summary>
    public string? PreviousValues { get; set; }

    /// <summary>
    ///     Gets or sets the new values of the entity after the operation.
    /// </summary>
    public string? NewValues { get; set; }

    /// <summary>
    ///     Gets or sets the properties of the entity that were modified.
    /// </summary>
    public string? ModifiedProperties { get; set; }

    /// <summary>
    ///     Gets or sets the primary key of the entity affected by the operation.
    /// </summary>
    public string? PrimaryKey { get; set; }
}