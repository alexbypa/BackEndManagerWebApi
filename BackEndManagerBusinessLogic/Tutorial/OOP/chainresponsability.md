Ecco un esempio di Design Pattern

### Codice:

```csharp
using Asp.Versioning;
using Flurl.Util;
using Microsoft.AspNetCore.Mvc;

namespace BackEndManagerWebApi.Controllers.oop {
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class DesignPatternsController : Controller {
        [HttpGet(Name = "chainofresponsability")]
        [MapToApiVersion("2.0")]
        public async Task<IActionResult> chainofresponsability(string username, string password) {
            var authentication = new AuthenticationHandler();
            var authorization = new AuthorizationHandler();

            authentication.SetNext(authorization);
            authentication.HandleResponse(new oop.Request { UserName = username, Password = password });
            return Ok();
        }
    }

    public class Request {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string ErrorMessage { get; set; }
    }
    public interface IResponseHandler {
        void SetNext(IResponseHandler handler);
        void HandleResponse(Request request);
    }

    public class ResponseBaseHandler : IResponseHandler {
        protected IResponseHandler _nextHandler;
        private bool canPatternRun = true;
        public virtual void HandleResponse(Request request) {
            if (!string.IsNullOrEmpty(request.ErrorMessage))
                Console.WriteLine(request.ErrorMessage);
            else if (_nextHandler != null)
                _nextHandler.HandleResponse(request);
        }
        public virtual void SetNext(IResponseHandler handler) {
            _nextHandler = handler;
        }
        protected virtual void RunException(Exception ex) {
            Console.WriteLine("[ERR] " + ex.ToString());
        }
    }
    public class AuthenticationHandler : ResponseBaseHandler {
        public override void HandleResponse(Request request) {
            Console.WriteLine($"Request handled by AuthenticationHandler. {request.UserName}");
            if (request.UserName != "admin")
                request.ErrorMessage = "User isnt admin";
            base.HandleResponse(request);
        }
        public override void SetNext(IResponseHandler nextHandler) {
            base.SetNext(nextHandler);
        }
    }
    public class AuthorizationHandler : ResponseBaseHandler {
        public override void HandleResponse(Request request) {
            Console.WriteLine("Request handled by AuthorizationHandler.");
            if (request.UserName == "error") {
                RunException(new Exception("Errore di prova "));
            }
            base.HandleResponse(request);
        }
        public override void SetNext(IResponseHandler nextHandler) {
            base.SetNext(nextHandler);
        }
    }
}
```


### DOC:
Un esempio reale e comune dell'uso del **Chain of Responsibility** design pattern è nella gestione delle richieste HTTP in un'applicazione web, specialmente nei **middleware** di un'applicazione **ASP.NET Core**.

### Scenario reale: Middleware pipeline in ASP.NET Core

Nel contesto di ASP.NET Core, ogni richiesta HTTP passa attraverso una catena di middleware. Ogni middleware può decidere se:
- Gestire completamente la richiesta (ad esempio, autenticazione, logging).
- Passare la richiesta al successivo middleware nella pipeline.

Questa struttura è un esempio pratico del **Chain of Responsibility** pattern.

### Struttura di Middleware

- Ogni middleware implementa un metodo chiamato `Invoke` o `InvokeAsync`, che riceve un "next" middleware da chiamare.
- Se il middleware può gestire la richiesta, lo fa e termina la catena. Altrimenti, passa la richiesta al middleware successivo chiamando `await next(context)`.

### Esempio di codice:

```csharp
public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public AuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.User.Identity.IsAuthenticated)
        {
            context.Response.StatusCode = 401; // Non autorizzato
        }
        else
        {
            await _next(context); // Passa al middleware successivo
        }
    }
}

// Registrazione del middleware nella pipeline
public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseMiddleware<AuthenticationMiddleware>();
        app.UseMiddleware<LoggingMiddleware>();
    }
}
```

### Altri esempi:
1. **Logging middleware**: Questo middleware potrebbe registrare tutte le richieste, ma passare il controllo alla richiesta successiva.
2. **Middleware di caching**: Se la richiesta è già stata cacheata, risponde senza passare al middleware successivo, altrimenti la passa.

### Benefici:
- **Flessibilità**: Puoi aggiungere o rimuovere facilmente i middleware dalla catena.
- **Estendibilità**: Ogni middleware è indipendente dagli altri, rispettando il **principio SRP (Single Responsibility Principle)**.

L'uso di middleware in ASP.NET Core è un esempio classico di Chain of Responsibility, dove ogni componente decide se gestire o delegare una richiesta.
