using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Sinks.Elasticsearch;
using Serilog;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackEndManagerBusinessLogic.healtchecks;
public static class healtchecksExtension {
    public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services, IConfiguration configuration) {

        HealthChecksOptions? healthChecksOptions = configuration.GetSection("HealthChecksOptions").Get<HealthChecksOptions>();
        if (healthChecksOptions == null) {
            return services;
        }
        var healthChecks = services.AddHealthChecks()
            .AddElasticsearch("http://localhost:9200", name: "ElasticSearch");

        services.AddSingleton<IHealthCheckPublisher, ElasticsearchHealthCheckPublisher>();
        services.Configure<HealthCheckPublisherOptions>(options =>
        {
            options.Delay = TimeSpan.FromSeconds(10);
            options.Period = TimeSpan.FromMinutes(1);
        });

        Log.Logger = new LoggerConfiguration()
        .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://10.0.1.119:9200")) {
            AutoRegisterTemplate = true,
            IndexFormat = "healthchecks-{0:yyyy.MM.dd}"
        })
        .CreateLogger();

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
        if (healthChecksOptions.SystemResourcesHealthCheck) {
            var systemHealth = new SystemResourcesHealthCheck();
            if (firstCheck != null)
                firstCheck.SetNext(systemHealth);
            else
                firstCheck = systemHealth;
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

public class ElasticsearchHealthCheckPublisher : IHealthCheckPublisher {
    public Task PublishAsync(HealthReport report, CancellationToken cancellationToken) {
        // Converti il report in un oggetto log e invialo a Elasticsearch
        foreach (var entry in report.Entries) {
            Log.Information("Health check for {Name} reported {Status}", entry.Key, entry.Value.Status);
        }
        return Task.CompletedTask;
    }
}
