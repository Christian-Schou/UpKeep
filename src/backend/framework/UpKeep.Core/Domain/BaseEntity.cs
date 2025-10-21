using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using UpKeep.Core.Domain.Contract;

namespace UpKeep.Core.Domain;

public class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; protected init; } = default!;

    [NotMapped] public Collection<DomainEvent> DomainEvents { get; } = [];

    public void QueueDomainEvent(DomainEvent @event)
    {
        if (!DomainEvents.Contains(@event))
            DomainEvents.Add(@event);
    }
}

public abstract class BaseEntity : BaseEntity<Guid>
{
    protected BaseEntity() => Id = Guid.CreateVersion7();
}