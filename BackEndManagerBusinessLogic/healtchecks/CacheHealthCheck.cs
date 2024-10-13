using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackEndManagerBusinessLogic.healtchecks;
public class CacheHealthCheck : HealthCheckHandler {
    protected override async Task<HealthCheckResult> PerformHealthCheckAsync() {
        try {
            await Task.Delay(10);   
            if (new Random().Next(100) < 50)
                return HealthCheckResult.Healthy("Redis is reachable.");
            else
                return HealthCheckResult.Degraded("Redis is slow.");
        } catch (Exception ex) {
            return HealthCheckResult.Unhealthy("Redis is unreachable.", ex);
        }
    }
}