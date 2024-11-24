using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackEndManagerBusinessLogic.healtchecks;
public class CacheHealthCheck : HealthCheckHandler {
    protected override async Task<HealthCheckResult> PerformHealthCheckAsync() {
        var currentCacheSize = GC.GetTotalMemory(false);
        await Task.Delay(10);
        if (currentCacheSize < 1000) {
            return HealthCheckResult.Healthy("Memory cache is within limits.");
        } else {
            return HealthCheckResult.Unhealthy("Memory cache usage has exceeded the configured limit.");
        }
    }
}