namespace UpKeep.Core.Audit;

/// <summary>
///     Specifies the type of audit trail event.
/// </summary>
public enum TrailType
{
    /// <summary>
    ///     No audit trail event.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Entity creation event.
    /// </summary>
    Create = 1,

    /// <summary>
    ///     Entity update event.
    /// </summary>
    Update = 2,

    /// <summary>
    ///     Entity deletion event.
    /// </summary>
    Delete = 3
}