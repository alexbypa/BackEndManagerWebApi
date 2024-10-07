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
    li.textContent = `NOTIFICA : ${d.notificationType}`;
    li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `LENGTH : ${d.message.contentLength}`;
    li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `HTTP STATUS: ${d.message.httpStatus}`;
    li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `CONTENT: ${d.message.content}`;
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