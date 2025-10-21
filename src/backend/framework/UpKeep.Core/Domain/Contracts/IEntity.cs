using System.Collections.ObjectModel;

namespace UpKeep.Core.Domain.Contract;

public interface IEntity
{
    Collection<DomainEvent> DomainEvents { get; }
}

public interface IEntity<out TId> : IEntity
{
    TId Id { get; }
}