using UpKeep.Core.Domain.Contracts;

namespace UpKeep.Core.Domain;

/// <summary>
///     Represents an auditable entity with support for soft deletion and metadata tracking.
/// </summary>
/// <typeparam name="TId">The type of the entity identifier.</typeparam>
public class AuditableEntity<TId> : BaseEntity<TId>, IAuditable, ISoftDeletable
{
    /// <summary>
    ///     Gets or sets the date and time when the entity was created.
    /// </summary>
    public DateTimeOffset CreatedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who created the entity.
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the entity was last updated.
    /// </summary>
    public DateTimeOffset UpdatedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who last updated the entity.
    /// </summary>
    public Guid? UpdatedBy { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the entity was softly deleted.
    /// </summary>
    public DateTimeOffset? DeletedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who softly deleted the entity.
    /// </summary>
    public Guid? DeletedBy { get; set; }
}

/// <summary>
///     Represents an auditable entity with a GUID identifier.
/// </summary>
public abstract class AuditableEntity : AuditableEntity<Guid>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AuditableEntity" /> class with a version 7 GUID.
    /// </summary>
    protected AuditableEntity()
    {
        Id = Guid.CreateVersion7();
    }
}