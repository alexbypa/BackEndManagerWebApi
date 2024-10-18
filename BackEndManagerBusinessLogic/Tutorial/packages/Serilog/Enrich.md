Per cambiare dinamicamente il template di logging quando scrivi su un sink Elasticsearch con **Serilog**, puoi farlo configurando il logger per supportare formati personalizzati e dinamici. Serilog ti consente di utilizzare **enricher** e **custom formatters** per adattare i dati inviati al sink Elasticsearch.

### 1. **Utilizzare Enricher per Dati Dinamici:**
Gli **enricher** ti permettono di arricchire dinamicamente i log con informazioni aggiuntive prima di inviarli al sink. Puoi usarli per modificare il template del log in base a condizioni specifiche.

Ecco un esempio di come potresti farlo:

#### A. Configurare un Enricher Personalizzato:
Puoi creare un `ILogEventEnricher` per modificare dinamicamente i campi del log.

```csharp
public class DynamicTemplateEnricher : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        // Esempio di logica dinamica per arricchire il template
        if (logEvent.Properties.ContainsKey("Action"))
        {
            var action = logEvent.Properties["Action"].ToString();
            if (action == "SpecialAction")
            {
                logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("CustomTemplate", "Special template for this action"));
            }
            else
            {
                logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("CustomTemplate", "Default template"));
            }
        }
    }
}
```

#### B. Aggiungere l'Enricher al Logger:
Puoi poi registrare questo enricher nella configurazione del logger.

```csharp
Log.Logger = new LoggerConfiguration()
    .Enrich.With(new DynamicTemplateEnricher()) // Usa l'enricher dinamico
    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
    {
        AutoRegisterTemplate = true,  // Se necessario, auto registra il template
        IndexFormat = "log-index-{0:yyyy.MM.dd}", // Definisci un formato dinamico per l'indice
        // Aggiungi altre opzioni come richiesto
    })
    .CreateLogger();
```

### 2. **Configurare un Formatter Personalizzato:**
Un'altra opzione è creare un formatter personalizzato per formattare il messaggio del log in modo dinamico prima che venga inviato al sink.

#### A. Creare un `ILogEventFormatter` Personalizzato:
Puoi implementare il formatter in base a come vuoi formattare il tuo log.

```csharp
public class CustomElasticFormatter : ITextFormatter
{
    public void Format(LogEvent logEvent, TextWriter output)
    {
        // Logica personalizzata per formattare il messaggio dinamicamente
        var action = logEvent.Properties.ContainsKey("Action") ? logEvent.Properties["Action"].ToString() : "Unknown";
        
        if (action == "SpecialAction")
        {
            output.Write("Special format: ");
        }
        else
        {
            output.Write("Default format: ");
        }

        output.Write(logEvent.MessageTemplate.Text); // Scrivi il template del messaggio
    }
}
```

#### B. Aggiungere il Formatter al Sink Elasticsearch:
Ora puoi configurare Serilog per utilizzare il formatter personalizzato.

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
    {
        CustomFormatter = new CustomElasticFormatter(), // Usa il formatter personalizzato
        AutoRegisterTemplate = true,
        IndexFormat = "log-index-{0:yyyy.MM.dd}",
    })
    .CreateLogger();
```

### 3. **Scegliere i Template in Base a Condizioni nel Log:**
Se hai bisogno di cambiare dinamicamente il template stesso (ad esempio scegliendo tra vari tipi di template di logging), puoi farlo condizionatamente nel tuo codice:

```csharp
var isSpecialAction = action == "SpecialAction";
var logMessageTemplate = isSpecialAction ? 
    "SpecialAction: {action} request: {request} ..." : 
    "Action: {action} request: {request} ...";

Log.Information(logMessageTemplate, action, request, response, start, stop, httpError, isRetry, idTransaction, machineName, action);
```

### 4. **Aggiungere Tag per Categorizzare i Log:**
Un'altra strategia potrebbe essere l'uso dei **tag** per categorizzare i log dinamicamente. Questo ti consente di creare modelli di query più complessi su Elasticsearch per gestire i template in fase di consultazione:

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
    {
        AutoRegisterTemplate = true,
        IndexFormat = "log-index-{0:yyyy.MM.dd}",
        Tags = new List<string> { "dynamicTemplate", "environment-production" }, // Usa tag dinamici
    })
    .CreateLogger();
```

### Riepilogo:
- **Enricher**: Modifica dinamicamente i campi del log in base a condizioni.
- **Formatter**: Personalizza la formattazione del log prima di inviarlo a Elasticsearch.
- **Template condizionale**: Modifica il template del messaggio direttamente nel codice in base a condizioni.
- **Tag dinamici**: Aggiungi tag ai log per categorizzare dinamicamente i dati.

Queste strategie ti permettono di avere il controllo dinamico sui template di log quando scrivi su Elasticsearch.
