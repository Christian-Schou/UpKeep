using System.Collections.ObjectModel;

namespace UpKeep.Core.Domain.Contracts;

/// <summary>
///     Represents a domain entity with domain events.
/// </summary>
public interface IEntity
{
    /// <summary>
    ///     Gets the collection of domain events associated with the entity.
    /// </summary>
    Collection<DomainEvent> DomainEvents { get; }
}

/// <summary>
///     Represents a domain entity with a strongly-typed identifier and domain events.
/// </summary>
/// <typeparam name="TId">The type of the entity identifier.</typeparam>
public interface IEntity<out TId> : IEntity
{
    /// <summary>
    ///     Gets the unique identifier for the entity.
    /// </summary>
    TId Id { get; }
}