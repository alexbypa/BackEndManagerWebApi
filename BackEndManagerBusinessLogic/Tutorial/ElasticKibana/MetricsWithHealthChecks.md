Per inviare le metriche di **HealthCheck** a **ElasticSearch**, puoi integrare il monitoraggio della salute con un **Publisher custom** che invii i risultati a ElasticSearch. Ecco un esempio di come implementarlo usando il pacchetto `Microsoft.Extensions.Diagnostics.HealthChecks` insieme a `Elastic.Clients.Elasticsearch` per il collegamento a ElasticSearch:

### 1. Configura l’HealthCheck e il Publisher

#### 1.1 HealthCheck Configuration
Configura gli **HealthCheck** nel servizio, aggiungendo i vari controlli desiderati (es. database, API esterne) nel metodo `ConfigureServices`.

```csharp
services.AddHealthChecks()
    .AddCheck("Database", new SqlConnectionHealthCheck(connectionString))
    .AddCheck("API", new ApiHealthCheck(apiUrl));
```

#### 1.2 Implementa un Custom HealthCheck Publisher

Crea una classe che implementa `IHealthCheckPublisher` per intercettare i risultati degli **HealthCheck** e inviarli a ElasticSearch.

```csharp
public class ElasticSearchHealthCheckPublisher : IHealthCheckPublisher
{
    private readonly ElasticsearchClient _elasticClient;

    public ElasticSearchHealthCheckPublisher(ElasticsearchClient elasticClient)
    {
        _elasticClient = elasticClient;
    }

    public async Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
    {
        var document = new
        {
            Status = report.Status.ToString(),
            Checks = report.Entries.Select(e => new
            {
                Name = e.Key,
                Status = e.Value.Status.ToString(),
                Duration = e.Value.Duration,
                Description = e.Value.Description
            }),
            Timestamp = DateTime.UtcNow
        };

        await _elasticClient.IndexDocumentAsync(document, cancellationToken);
    }
}
```

#### 1.3 Registra il Publisher e Configura ElasticSearch

Assicurati di registrare il publisher e configurare l’istanza di `ElasticsearchClient` in `ConfigureServices`.

```csharp
services.AddSingleton(new ElasticsearchClient(new ElasticsearchClientSettings(new Uri("http://localhost:9200"))));
services.AddSingleton<IHealthCheckPublisher, ElasticSearchHealthCheckPublisher>();
services.Configure<HealthCheckPublisherOptions>(options =>
{
    options.Delay = TimeSpan.FromSeconds(10);
    options.Period = TimeSpan.FromSeconds(60);
});
```

### 2. Visualizza le Metriche in Kibana

Una volta che le metriche vengono inviate a ElasticSearch, puoi visualizzarle in Kibana creando una dashboard personalizzata per monitorare lo stato di salute dell’applicazione e dei suoi componenti.

### Note Finali

Questa implementazione invia i dati di HealthCheck a ElasticSearch e offre flessibilità in termini di configurazione e visualizzazione, soprattutto in produzione, dove il monitoraggio della salute e delle prestazioni è fondamentale.
