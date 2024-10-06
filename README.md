## SIGNALR ##

### Configurazione ###
 **program.cs**
```csharp
#region signalr
builder.Services.AddCors(options => options.AddPolicy(name: "enablecorsforclient", builder => {
    builder.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .WithOrigins("http://localhost:5051")
    .SetIsOriginAllowed((host) => true);
}));
builder.Services.AddScoped<NotificationHub>();
builder.Services.AddSignalR().AddHubOptions<NotificationHub>(options => {
    options.EnableDetailedErrors = true;
});
builder.Services.AddSingleton<INotificationService, NotificationService>();
builder.Services.AddTransient<yourBusinessLogic>();

var app = builder.Build();

app.UseStaticFiles();
#region signalr
app.UseCors("enablecorsforclient");
app.MapHub<NotificationHub>("/NotificationHub");
#endregion
```

1. **spiegazione program.cs:**:
   - (AddCors) Aggiungere AdCors se i client si trovano su altro host.
   - (AddScoped) Aggiunge l' Hub tipizzato.
   - (AddSignalR) Aggiunge il servizio signalR Microsoft.AspNetCore.SignalR ( usare Redis su sistemi distribuiti )
   - (Single-responsibility principle) Aggiunge l' interfaccia per separare l' uso di Hub dalla business logic 
   - (business logic) Aggiunge la tua business logic

### Codice Javascript ###
```javascript
"use strict";

const opts = {
    skipNegotiation: true,
    transport: signalR.HttpTransportType.WebSockets
};
var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub", opts)
    .configureLogging(signalR.LogLevel.Debug) 
    .withAutomaticReconnect([...Array(10)].map((_, i) => i ? 5000 : 0))
    .build();


connection.error
connection.on("SendMessage", wsgotdata );
function wsgotdata(d) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `Notifica : ${d.notificationType} : Sport ${d.message.sport} : Cat: ${d.message.category} : tournament: ${d.message.tournament}`;
    li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `content: ${d.message.additionalInfo}`;
    console.log(d);
}

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
```

