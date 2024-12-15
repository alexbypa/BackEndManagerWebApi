Ecco un esempio completo di integrazione di **OpenTelemetry** con **Elasticsearch** in un'applicazione ASP.NET Core. Questo esempio mostra come raccogliere metriche e tracce dall'applicazione e inviarle a un cluster Elasticsearch.

### 1. Prerequisiti

Assicurati di avere:
- **.NET SDK** installato (versione 6.0 o superiore).
- Un'istanza di **Elasticsearch** in esecuzione (puoi eseguirlo localmente o utilizzare un servizio cloud).
- Un progetto ASP.NET Core (puoi crearne uno nuovo se necessario).

### 2. Creazione del Progetto ASP.NET Core

Puoi creare un nuovo progetto ASP.NET Core usando il seguente comando:

```bash
dotnet new web -n OpenTelemetryElasticExample
cd OpenTelemetryElasticExample
```

### 3. Aggiungere i Pacchetti NuGet

Aggiungi i pacchetti necessari al progetto:

```bash
dotnet add package OpenTelemetry
dotnet add package OpenTelemetry.Exporter.Elasticsearch
dotnet add package OpenTelemetry.Instrumentation.AspNetCore
```

### 4. Configurazione di OpenTelemetry in `Program.cs`

Modifica il file `Program.cs` per configurare OpenTelemetry e collegarlo a Elasticsearch.

```csharp
using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

// Configurazione di OpenTelemetry
builder.Services.AddOpenTelemetryTracing(tracerProviderBuilder =>
{
    tracerProviderBuilder
        .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("OpenTelemetryElasticService"))
        .AddAspNetCoreInstrumentation() // Aggiunge l'instrumentazione per ASP.NET Core
        .AddHttpClientInstrumentation() // Aggiunge l'instrumentazione per i client HTTP
        .AddElasticSearchExporter(options =>
        {
            options.IndexName = "your-index-name"; // Nome dell'indice Elasticsearch
            options.Endpoint = new Uri("http://localhost:9200"); // URL del tuo cluster Elasticsearch
        });
});

var app = builder.Build();

// Configurazione degli endpoint
app.MapGet("/", () => "Hello OpenTelemetry with Elasticsearch!");

app.Run();
```

### 5. Eseguire l'Applicazione

Puoi eseguire l'applicazione con il seguente comando:

```bash
dotnet run
```

### 6. Verificare l'Integrazione

1. **Richiesta HTTP**: Fai una richiesta HTTP al tuo endpoint, ad esempio, navigando su `http://localhost:5000` (o l'indirizzo configurato per la tua applicazione). Questo attiverà l'instrumentazione di OpenTelemetry e genererà un tracciamento.

2. **Verifica in Elasticsearch**: Accedi a Elasticsearch (tipicamente su `http://localhost:9200`) e controlla l'indice specificato per verificare se i dati sono stati inviati. Puoi utilizzare un tool come **Kibana** o semplici richieste CURL per esaminare i dati.

Esempio di comando CURL per ottenere i documenti dall'indice:

```bash
curl -X GET "localhost:9200/your-index-name/_search?pretty"
```

### 7. Visualizzazione con Kibana

Se stai usando Kibana, puoi creare una nuova visualizzazione per l'indice appena creato per vedere i dati di telemetry. In Kibana:

- Vai alla sezione **Discover**.
- Seleziona l'indice creato (ad esempio, `your-index-name`).
- Puoi esplorare i dati e creare visualizzazioni basate sui tracciamenti e sulle metriche inviate.

### 8. Considerazioni Finali

- **Configurazioni Avanzate**: Puoi personalizzare ulteriormente l'invio di dati a Elasticsearch, come il formato del documento o l'aggiunta di attributi specifici ai tracciamenti.
- **Metriche Aggiuntive**: Oltre all'instrumentazione ASP.NET Core, puoi aggiungere ulteriori strumenti di tracciamento o monitoraggio, come l'instrumentazione di database e client HTTP.
- **Prestazioni**: Monitora le performance della tua applicazione mentre utilizzi OpenTelemetry, assicurandoti che l'overhead di tracciamento sia minimo.

Questo esempio fornisce una base per iniziare a utilizzare OpenTelemetry con Elasticsearch, permettendo di raccogliere e visualizzare informazioni preziose sul funzionamento della tua applicazione.
