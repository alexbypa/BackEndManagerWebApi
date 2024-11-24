using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackEndManagerBusinessLogic.healtchecks;
public abstract class HealthCheckHandler : IHealthCheck {
    protected HealthCheckHandler _nextHandler;

    public HealthCheckHandler SetNext(HealthCheckHandler nextHandler) {
        _nextHandler = nextHandler;
        return nextHandler;
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default) {
        // Lista per raccogliere tutti i risultati
        var results = new List<HealthCheckResult>();

        // Esegui il controllo corrente e aggiungilo alla lista
        var currentResult = await PerformHealthCheckAsync();
        results.Add(currentResult);

        // Passa al prossimo controllo nella catena, se esiste
        if (_nextHandler != null) {
            var nextResult = await _nextHandler.CheckHealthAsync(context, cancellationToken);
            results.Add(nextResult);
        }

        // Aggrega tutti i risultati
        var finalStatus = results.Any(r => r.Status == HealthStatus.Unhealthy) ? HealthStatus.Unhealthy :
                          results.Any(r => r.Status == HealthStatus.Degraded) ? HealthStatus.Degraded :
                          HealthStatus.Healthy;

        var description = string.Join("; ", results.Select(r => r.Description));
        //TODO: Ok ma si vede solo unhealthy !!!!
        // Restituisci un risultato aggregato
        return new HealthCheckResult(finalStatus, description);
    }

    // Metodo che deve essere implementato dai singoli handler
    protected abstract Task<HealthCheckResult> PerformHealthCheckAsync();
}