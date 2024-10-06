## SIGNALR ##

### Configurazione ###
#### program.cs ####
```csharp
#region signalr
builder.Services.AddCors(options => options.AddPolicy(name: "enablecorsforclient", builder => {
    builder.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .WithOrigins("http://localhost:5051")
    .SetIsOriginAllowed((host) => true);
}));
```

1. **injects services:**:
   - Aggiungere AdCors se i client si trovano su altro host.



Per separare la **business logic** dall'integrazione con SignalR rispettando i principi SOLID, è possibile utilizzare un pattern come il **Mediator Pattern** o **Observer Pattern**, dove SignalR diventa un "notificatore" che si occupa esclusivamente di comunicare con i client.

L'idea è quella di creare un servizio di **notifica** separato dalla business logic che venga utilizzato solo per inviare aggiornamenti ai client attraverso SignalR, mantenendo i due componenti disaccoppiati. 

Ecco come farlo in modo strutturato:

### 1. **Definizione dell'interfaccia di notifica (INotificationService)**
Questo servizio sarà responsabile dell'invio delle notifiche tramite SignalR.

```csharp
public interface INotificationService
{
    Task NotifyClientsAsync(string message);
}
```

### 2. **Implementazione dell'interfaccia di notifica con SignalR**
Questa implementazione usa un **hub tipizzato** per inviare messaggi ai client.

```csharp
public class NotificationService : INotificationService
{
    private readonly IHubContext<NotificationHub, INotificationClient> _hubContext;

    public NotificationService(IHubContext<NotificationHub, INotificationClient> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task NotifyClientsAsync(string message)
    {
        await _hubContext.Clients.All.ReceiveMessage(message);
    }
}
```

### 3. **Hub Tipizzato**
Un **hub tipizzato** definisce i metodi che i client possono ricevere.

```csharp
public interface INotificationClient
{
    Task ReceiveMessage(string message);
}

public class NotificationHub : Hub<INotificationClient>
{
    // Non è necessario implementare nulla, sarà solo un hub per le notifiche.
}
```

### 4. **Business Logic**
La logica di business non sa nulla di SignalR. Si limita a fare il proprio lavoro e a invocare il servizio di notifica quando necessario.

```csharp
public class BusinessLogic
{
    private readonly INotificationService _notificationService;

    public BusinessLogic(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public async Task PerformOperation()
    {
        // Esegui operazioni di business
        // ...

        // Invia notifica ai client tramite il servizio di notifica
        await _notificationService.NotifyClientsAsync("L'operazione è stata eseguita!");
    }
}
```

### 5. **Iniezione delle Dipendenze (Dependency Injection)**
Nel `Startup.cs`, configurare i servizi per l'iniezione delle dipendenze:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddSignalR();
    services.AddSingleton<INotificationService, NotificationService>();
    services.AddTransient<BusinessLogic>();
    services.AddControllers();  // Configura Web API
}
```

### 6. **Controller API**
Il controller usa la business logic senza preoccuparsi di SignalR.

```csharp
[ApiController]
[Route("api/[controller]")]
public class OperationsController : ControllerBase
{
    private readonly BusinessLogic _businessLogic;

    public OperationsController(BusinessLogic businessLogic)
    {
        _businessLogic = businessLogic;
    }

    [HttpPost("perform-operation")]
    public async Task<IActionResult> PerformOperation()
    {
        await _businessLogic.PerformOperation();
        return Ok("Operazione eseguita con successo!");
    }
}
```

### 7. **Client SignalR**
I client devono connettersi al **NotificationHub** e implementare il metodo `ReceiveMessage`.

```javascript
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationHub")
    .build();

connection.on("ReceiveMessage", function (message) {
    console.log("Notifica ricevuta: " + message);
});

connection.start();
```

### Benefici:
1. **Disaccoppiamento**: La business logic è separata dal meccanismo di notifica, rispettando il principio di **Single Responsibility** (SRP).
2. **Testabilità**: Entrambi i componenti possono essere testati separatamente.
3. **Flessibilità**: La logica di notifica può essere cambiata senza toccare la logica di business.

In questo modo, SignalR e la business logic sono disaccoppiati e rispettano i principi SOLID.
