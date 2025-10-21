using System.Collections.ObjectModel;
using System.Text.Json;

namespace UpKeep.Core.Audit;

/// <summary>
///     Data transfer object representing a trail of changes for auditing purposes.
/// </summary>
public class TrailDto
{
    /// <summary>
    ///     Gets or sets the unique identifier for the trail entry.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the change occurred.
    /// </summary>
    public DateTimeOffset DateTime { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the user who made the change.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    ///     Gets or sets the key values identifying the entity.
    /// </summary>
    public Dictionary<string, object?> KeyValues { get; set; } = [];

    /// <summary>
    ///     Gets or sets the old values of the entity before the change.
    /// </summary>
    public Dictionary<string, object?> OldValues { get; set; } = [];

    /// <summary>
    ///     Gets or sets the new values of the entity after the change.
    /// </summary>
    public Dictionary<string, object?> NewValues { get; set; } = [];

    /// <summary>
    ///     Gets or sets the collection of properties that were modified.
    /// </summary>
    public Collection<string> ModifiedProperties { get; set; } = [];

    /// <summary>
    ///     Gets or sets the type of the trail event.
    /// </summary>
    public TrailType Type { get; set; }

    /// <summary>
    ///     Gets or sets the name of the table affected by the change.
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    ///     The serializer options used for JSON serialization.
    /// </summary>
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true
    };

    /// <summary>
    ///     Converts a <see cref="TrailDto" /> to an <see cref="AuditTrail" /> entity.
    /// </summary>
    /// <returns>An <see cref="AuditTrail" /> instance representing this trail entry.</returns>
    public AuditTrail ToAuditTrail()
    {
        return new AuditTrail
        {
            Id = Guid.CreateVersion7(),
            UserId = UserId,
            Operation = Type.ToString(),
            Entity = TableName,
            DateTime = DateTime,
            PrimaryKey = JsonSerializer.Serialize(KeyValues, SerializerOptions),
            PreviousValues = OldValues.Count == 0
                ? null
                : JsonSerializer.Serialize(OldValues, SerializerOptions),
            NewValues = NewValues.Count == 0
                ? null
                : JsonSerializer.Serialize(NewValues, SerializerOptions),
            ModifiedProperties = ModifiedProperties.Count == 0
                ? null
                : JsonSerializer.Serialize(ModifiedProperties, SerializerOptions)
        };
    }
}