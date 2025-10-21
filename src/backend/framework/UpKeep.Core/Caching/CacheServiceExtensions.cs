namespace UpKeep.Core.Caching;

/// <summary>
///     Extension methods for <see cref="ICacheService" /> to simplify cache retrieval and population.
/// </summary>
public static class CacheServiceExtensions
{
    /// <summary>
    ///     Retrieves a value from the cache if present; otherwise, gets the value using the provided callback and stores it in
    ///     the cache.
    /// </summary>
    /// <typeparam name="T">The type of the value to retrieve or set.</typeparam>
    /// <param name="cache">The cache service instance.</param>
    /// <param name="key">The cache key.</param>
    /// <param name="getItemCallback">A callback to retrieve the value if it is not in the cache.</param>
    /// <param name="slidingExpiration">The sliding expiration time for the cache entry, or null for default.</param>
    /// <returns>The cached or newly retrieved value, or null if not found.</returns>
    public static T? GetOrSet<T>(this ICacheService cache, string key, Func<T?> getItemCallback,
        TimeSpan? slidingExpiration = null)
    {
        var value = cache.Get<T>(key);

        if (value is not null) return value;

        value = getItemCallback();

        if (value is not null) cache.Set(key, value, slidingExpiration);

        return value;
    }

    /// <summary>
    ///     Asynchronously retrieves a value from the cache if present; otherwise, gets the value using the provided
    ///     asynchronous callback and stores it in the cache.
    /// </summary>
    /// <typeparam name="T">The type of the value to retrieve or set.</typeparam>
    /// <param name="cache">The cache service instance.</param>
    /// <param name="key">The cache key.</param>
    /// <param name="task">An asynchronous callback to retrieve the value if it is not in the cache.</param>
    /// <param name="slidingExpiration">The sliding expiration time for the cache entry, or null for default.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains the cached or newly retrieved
    ///     value.
    /// </returns>
    public static async Task<T> GetOrSetAsync<T>(this ICacheService cache, string key, Func<Task<T>> task,
        TimeSpan? slidingExpiration = null, CancellationToken cancellationToken = default)
    {
        var value = await cache.GetAsync<T>(key, cancellationToken);

        if (value is not null) return value;

        value = await task();

        if (value is not null) await cache.SetAsync(key, value, slidingExpiration, cancellationToken);

        return value;
    }
}