using UpKeep.Core.Domain.Contract;

namespace UpKeep.Core.Domain;

public class AuditableEntity<TId> : BaseEntity<TId>, IAuditable, ISoftDeletable
{
    public DateTimeOffset CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTimeOffset UpdatedOn { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTimeOffset? DeletedOn { get; set; }
    public Guid? DeletedBy { get; set; }
}

public abstract class AuditableEntity : AuditableEntity<Guid>
{
    protected AuditableEntity() => Id = Guid.CreateVersion7();
}