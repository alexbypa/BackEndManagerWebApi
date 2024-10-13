using Microsoft.Extensions.Diagnostics.HealthChecks;
using StackExchange.Redis;

namespace BackEndManagerBusinessLogic.healtchecks;
public class RedisHealthCheck : HealthCheckHandler {
    private readonly string _redisConnectionString;

    public RedisHealthCheck(string redisConnectionString) {
        _redisConnectionString = redisConnectionString;
    }

    protected override async Task<HealthCheckResult> PerformHealthCheckAsync() {
        try {
            var redis = ConnectionMultiplexer.Connect(_redisConnectionString);
            var database = redis.GetDatabase();
            var ping = await database.PingAsync();

            return ping.TotalMilliseconds < 100
                ? HealthCheckResult.Healthy("Redis is reachable.")
                : HealthCheckResult.Degraded("Redis is slow.");
        } catch (Exception ex) {
            return HealthCheckResult.Unhealthy("Redis is unreachable.", ex);
        }
    }
}
