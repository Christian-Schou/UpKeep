namespace UpKeep.Core.Domain.Contracts;

/// <summary>
///     Interface for auditable entities, providing properties for tracking creation and update metadata.
/// </summary>
public interface IAuditable
{
    /// <summary>
    ///     Gets or sets the date and time when the entity was created.
    /// </summary>
    DateTimeOffset CreatedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who created the entity.
    /// </summary>
    Guid CreatedBy { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the entity was last updated.
    /// </summary>
    DateTimeOffset UpdatedOn { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who last updated the entity.
    /// </summary>
    Guid? UpdatedBy { get; set; }
}