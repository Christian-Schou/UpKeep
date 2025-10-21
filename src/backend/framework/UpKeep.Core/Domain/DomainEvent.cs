using UpKeep.Core.Domain.Contracts;

namespace UpKeep.Core.Domain;

public abstract record DomainEvent : IDomainEvent
{
    public DateTime RaisedAt { get; protected set; } = DateTime.UtcNow;
}