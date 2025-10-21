using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using UpKeep.Core.Domain.Contracts;

namespace UpKeep.Core.Domain;

/// <summary>
///     Represents a base entity with a strongly-typed identifier and domain event support.
/// </summary>
/// <typeparam name="TId">The type of the entity identifier.</typeparam>
public class BaseEntity<TId> : IEntity<TId>
{
    /// <summary>
    ///     Gets the unique identifier for the entity.
    /// </summary>
    public TId Id { get; protected init; } = default!;

    /// <summary>
    ///     Gets the collection of domain events associated with the entity.
    /// </summary>
    [NotMapped]
    public Collection<DomainEvent> DomainEvents { get; } = [];

    /// <summary>
    ///     Queues a domain event to be dispatched.
    /// </summary>
    /// <param name="event">The domain event to queue.</param>
    public void QueueDomainEvent(DomainEvent @event)
    {
        if (!DomainEvents.Contains(@event))
            DomainEvents.Add(@event);
    }
}

/// <summary>
///     Represents a base entity with a GUID identifier and domain event support.
/// </summary>
public abstract class BaseEntity : BaseEntity<Guid>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BaseEntity" /> class with a version 7 GUID.
    /// </summary>
    protected BaseEntity()
    {
        Id = Guid.CreateVersion7();
    }
}