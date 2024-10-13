using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackEndManagerBusinessLogic.healtchecks;
public static class healtchecksExtension {
    public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services, IConfiguration configuration) {

        HealthChecksOptions? healthChecksOptions = configuration.GetSection("HealthChecksOptions").Get<HealthChecksOptions>();
        if (healthChecksOptions == null) {
            return services;
        }
        var healthChecks = services.AddHealthChecks();
        HealthCheckHandler? firstCheck = null;

        if (healthChecksOptions.RedisCheck && !string.IsNullOrEmpty(healthChecksOptions.ConnectionStrings?.Redis)) {
            var redisCheck = new RedisHealthCheck(healthChecksOptions.ConnectionStrings.Redis);
            if (firstCheck != null)
                firstCheck.SetNext(redisCheck);
            else
                firstCheck = redisCheck;
        }
        if (healthChecksOptions.CacheHealthCheck) {
            var cacheHealthCheck = new CacheHealthCheck();
            if (firstCheck != null)
                firstCheck.SetNext(cacheHealthCheck);
            else
                firstCheck = cacheHealthCheck;
        }
            if (firstCheck != null)
                healthChecks.AddCheck("dynamic_chain_health_check", firstCheck);

        services.AddHealthChecksUI(setupSettings: setup =>
        {
            setup.SetEvaluationTimeInSeconds(
                healthChecksOptions.UiSettings.SecondPollinginterval == 0 ? 
                5 : 
                healthChecksOptions.UiSettings.SecondPollinginterval);
            //setup.AddHealthCheckEndpoint("endpointLocal", healthChecksOptions.UiSettings.Uri);
            setup.SetNotifyUnHealthyOneTimeUntilChange();
        }).AddSqlServerStorage(healthChecksOptions.ConnectionStrings.SqlServer);
        return services;
    }
}
