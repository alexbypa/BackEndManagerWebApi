"use strict";

//conn = signalr_init();
//signalr_start(conn);
//function signalr_init() {
//    const wsuri = `${kiron.endpoint}/notificationoffer`;
//    const loglevel = signalR.LogLevel[qs.get("signalr_loglevel")] || signalR.LogLevel.None;
//    const opts = {
//        skipNegotiation: true,
//        transport: signalR.HttpTransportType.WebSockets
//    };
//    const c = new signalR.HubConnectionBuilder().withUrl(wsuri, opts).withAutomaticReconnect([...Array(10)].map((_, i) => i ? 5000 : 0)).configureLogging(loglevel).build();
//    c.on("SendMessage", wsgotdata);
//    c.onclose(() => {
//        console.log("Connectiond closed. Reconnecting...");
//        signalr_start(c);
//    }
//    );
//    return c;
//}
//function signalr_start(c) {
//    if (!c)
//        return console.warn("Signalr is not initialized");
//    c.start().then(() => {
//        console.log("Signalr is connected.");
//    }
//    ).catch(console.log);
//}



//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub")
//    .configureLogging(signalR.LogLevel.Information) // or Debug
//    .build();
const opts = {
    skipNegotiation: true,
    transport: signalR.HttpTransportType.WebSockets
};
var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub", opts)
    .configureLogging(signalR.LogLevel.Debug) 
    //.withAutomaticReconnect([...Array(10)].map((_, i) => i ? 5000 : 0))
    .build();


//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
connection.error
connection.on("SendMessage", wsgotdata );
function wsgotdata(d) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `Notifica ${d.notificationType} : Messaggio ${d.message}`;
    console.log(d);
}
//connection.start().catch(err => console.error(err.toString()));


//connection.on("ReceiveMessage", function (user, message) {
//    var li = document.createElement("li");
//    document.getElementById("messagesList").appendChild(li);
//    // We can assign user-supplied strings to an element's textContent because it
//    // is not interpreted as markup. If you're assigning in any other way, you 
//    // should be aware of possible script injection concerns.
//    li.textContent = `${user} says ${message}`;
//});

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