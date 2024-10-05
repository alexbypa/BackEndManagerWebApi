using BackEndManagerBusinessLogic.signalr.hubs;
using Microsoft.AspNetCore.SignalR;

namespace BackEndManagerBusinessLogic.signalr;
public class ClientNotifierADMManger : IObserverSignalR {
    private readonly IHubContext<NotificationHub> _hubContext;
    public ClientNotifierADMManger(IHubContext<NotificationHub> hubContext) {
        _hubContext = hubContext;
    }
    public void Update(string message) {
        _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
    }
}

