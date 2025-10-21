namespace UpKeep.Core.Caching;

/// <summary>
///     Provides methods for caching data in memory with support for synchronous and asynchronous operations.
/// </summary>
public interface ICacheService
{
    #region Get

    /// <summary>
    ///     Retrieves a cached value by key.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <returns>The cached value, or null if not found.</returns>
    T? Get<T>(string key);

    /// <summary>
    ///     Asynchronously retrieves a cached value by key.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains the cached value, or null if not
    ///     found.
    /// </returns>
    Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default);

    #endregion

    #region Refresh

    /// <summary>
    ///     Refreshes the expiration of a cached value by key.
    /// </summary>
    /// <param name="key">The cache key.</param>
    void Refresh(string key);

    /// <summary>
    ///     Asynchronously refreshes the expiration of a cached value by key.
    /// </summary>
    /// <param name="key">The cache key.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    Task RefreshAsync(string key, CancellationToken cancellationToken = default);

    #endregion

    #region Remove

    /// <summary>
    ///     Removes a cached value by key.
    /// </summary>
    /// <param name="key">The cache key.</param>
    void Remove(string key);

    /// <summary>
    ///     Asynchronously removes a cached value by key.
    /// </summary>
    /// <param name="key">The cache key.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    Task RemoveAsync(string key, CancellationToken cancellationToken = default);

    #endregion

    #region Set

    /// <summary>
    ///     Sets a value in the cache with an optional sliding expiration.
    /// </summary>
    /// <typeparam name="T">The type of the value to cache.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <param name="value">The value to cache.</param>
    /// <param name="slidingExpiration">The sliding expiration time, or null for default.</param>
    void Set<T>(string key, T Value, TimeSpan? slidingExpiration = null);

    /// <summary>
    ///     Asynchronously sets a value in the cache with an optional sliding expiration.
    /// </summary>
    /// <typeparam name="T">The type of the value to cache.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <param name="value">The value to cache.</param>
    /// <param name="slidingExpiration">The sliding expiration time, or null for default.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    Task SetAsync<T>(string key, T value, TimeSpan? slidingExpiration = null,
        CancellationToken cancellationToken = default);

    #endregion
}