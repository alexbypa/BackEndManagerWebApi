### CacheContext
```cs
using BEFactoryBusinessLayer.Logger;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace BEFactoryBusinessLayer.caching;

public interface ICache {
    T Get<T>(string key);
    void Set<T>(string key, T value, TimeSpan expiration);
    void Remove(string key);
}
public class InMemoryCache : ICache {
    private readonly Dictionary<string, CacheItem> _cache = new Dictionary<string, CacheItem>();
    public T Get<T>(string key) {
        if (_cache.TryGetValue(key, out CacheItem cacheItem) && cacheItem.Expiration > DateTime.Now) {
            loggerExtension.Trace("InMemoryCache-GET", key, Serilog.Events.LogEventLevel.Information, null, "Read data from InMemoryCache");
            return (T)cacheItem.Value;
        }
        return default(T);
    }
    public void Set<T>(string key, T value, TimeSpan expiration) {
        _cache[key] = new CacheItem { Value = value, Expiration = DateTime.Now.Add(expiration) };
        loggerExtension.Trace("InMemoryCache-GET", key, Serilog.Events.LogEventLevel.Information, null, "Set data from InMemoryCache");
    }
    public void Remove(string key) {
        _cache.Remove(key);
    }
    public void ShiftExpirationTime(string key, TimeSpan expiration) {
        if (_cache.TryGetValue(key, out CacheItem value)) {
            _cache.Remove(key);
            _cache[key] = new CacheItem { Value = value, Expiration = DateTime.Now.Add(expiration) };
        }
    }
    private class CacheItem {
        public object Value { get; set; }
        public DateTime Expiration { get; set; }
    }
}
public class RedisCache : ICache {
    private readonly IDatabase _database;
    public RedisCache(IOptions<RedisCacheOptions> options, IDatabase redisDatabase) {
        if (redisDatabase is not IDatabaseEmpty) {
            _database = redisDatabase;
        }
    }
    public T Get<T>(string key) {
        if (_database == null) {
            loggerExtension.Trace("Redis-GET", key, Serilog.Events.LogEventLevel.Error, null, "Cannot read data from Redis ( connection failure)");
            return default(T);
        }
        var value = _database.StringGet(key);
        if (value.HasValue) {
            loggerExtension.Trace("Redis-GET", key, Serilog.Events.LogEventLevel.Information, null, "Ok read data from Redis");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
        }
        return default(T);
    }
    public void Set<T>(string key, T value, TimeSpan expiration) {
        if (_database != null) {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(value);
            _database.StringSet(key, json, expiration);
            loggerExtension.Trace("Redis-SET", key, Serilog.Events.LogEventLevel.Information, null, "set data on Redis");
        } else
            loggerExtension.Trace("Redis-SET", key, Serilog.Events.LogEventLevel.Error, null, "Cannot set data on Redis ( connection failure)");
    }
    public void ShiftExpirationTime(string key, TimeSpan expiration) {
        bool keyExists = _database.KeyExists(key);
        if (keyExists) {
            _database.KeyExpire(key, expiration);
        }
    }
    public void Remove(string key) {
        bool response = _database.KeyDelete(key);
    }
}
public class CacheContext {
    private readonly IEnumerable<ICache> _cache;
    CacheStoreType _storeType;
    public CacheContext(IEnumerable<ICache> cache) {
        _cache = cache;
    }
    public T Get<T>(string key) {
        T data = default(T);
        ICache cache = _cache.FirstOrDefault(item => item is InMemoryCache);
        if (cache != null)
            return cache.Get<T>(key);
        cache = _cache.FirstOrDefault(item => item is RedisCache);
        if (cache != null)
            return cache.Get<T>(key);

        return default(T);
    }
    public void Set<T>(string key, T value, TimeSpan expiration) {
        ICache cache = _cache.FirstOrDefault(item => item is InMemoryCache);
        if (cache != null)
            cache.Set(key, value, expiration);
        cache = _cache.FirstOrDefault(item => item is RedisCache);
        if (cache != null)
            cache.Set(key, value, expiration);
    }
    public void Remove(string key) {
        ICache cache = _cache.FirstOrDefault(item => item is InMemoryCache);
        if (cache != null)
            cache.Remove(key);
        cache = _cache.FirstOrDefault(item => item is RedisCache);
        if (cache != null)
            cache.Remove(key);
    }
}
