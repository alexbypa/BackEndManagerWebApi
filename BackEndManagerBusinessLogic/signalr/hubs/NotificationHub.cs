using Microsoft.AspNetCore.SignalR;

namespace BackEndManagerBusinessLogic.signalr.hubs;
public class PayloadSocket {
    public string NotificationType { get; set; }
    public string Message { get; set; }
}
public interface INotification {
    Task SendMessage(PayloadSocket Payload);
}
public class NotificationHub : Hub<INotification> {
    public async Task SendMessage(PayloadSocket Payload) {
        await Clients.All.SendMessage(Payload);
    }
    public override Task OnConnectedAsync() {
        Context.Items["ConnectionId"] = Context.ConnectionId;
        return base.OnConnectedAsync();
    }
    
}
