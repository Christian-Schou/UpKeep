namespace UpKeep.Core.Domain.Contracts;

/// <summary>
///     Interface for entities that support soft deletion, providing properties for tracking deletion metadata.
/// </summary>
public interface ISoftDeletable
{
    /// <summary>
    ///     Gets or sets the date and time when the entity was soft deleted.
    /// </summary>
    DateTimeOffset? DeletedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who soft deleted the entity.
    /// </summary>
    Guid? DeletedBy { get; set; }
}