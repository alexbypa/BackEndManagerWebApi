using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackEndManagerBusinessLogic.healtchecks;
public class CacheHealthCheck : HealthCheckHandler {
    protected override async Task<HealthCheckResult> PerformHealthCheckAsync() {
        try {
            await Task.Delay(10);   
            if (1 == 1) //if (new Random().Next(100) < 50)
                return HealthCheckResult.Healthy("Cache local is ok.");
            else
                return HealthCheckResult.Degraded("Redis is slow.");
        } catch (Exception ex) {
            return HealthCheckResult.Unhealthy("Redis is unreachable.", ex);
        }
    }
}