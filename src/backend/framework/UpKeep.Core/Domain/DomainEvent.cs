using UpKeep.Core.Domain.Contracts;

namespace UpKeep.Core.Domain;

/// <summary>
///     Represents a domain event that can be raised within the domain model.
/// </summary>
public abstract record DomainEvent : IDomainEvent
{
    /// <summary>
    ///     Gets the date and time when the domain event was raised (in UTC).
    /// </summary>
    public DateTime RaisedAt { get; protected set; } = DateTime.UtcNow;
}