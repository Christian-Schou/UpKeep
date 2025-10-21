namespace UpKeep.Core.Domain.Contract;

public interface ISoftDeletable
{
    DateTimeOffset? DeletedOn { get; set; }
    Guid? DeletedBy { get; set; }
}