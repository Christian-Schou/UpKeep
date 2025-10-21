namespace UpKeep.Core.Domain.Contract;

public interface IAuditable
{
    DateTimeOffset CreatedOn { get; set; }
    Guid CreatedBy { get; set; }
    DateTimeOffset UpdatedOn { get; set; }
    Guid? UpdatedBy { get; set; }
}