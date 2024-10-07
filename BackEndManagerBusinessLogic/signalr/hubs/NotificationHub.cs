using Microsoft.AspNetCore.SignalR;

namespace BackEndManagerBusinessLogic.signalr.hubs;
public class PayloadSocket {
    public string? NotificationType { get; set; }
    public object? Message { get; set; }
}
public interface INotification {
    Task SendMessage<T>(T Payload);
}
public class NotificationHub : Hub<INotification> {
    public async Task SendMessage(PayloadSocket Payload) {
        await Clients.All.SendMessage(Payload);

    }
    public override Task OnConnectedAsync() {
        return base.OnConnectedAsync();
    }
}

public interface INotificationSocketService {
    Task NotifyClientsAsync(PayloadSocket payload);
}
public class NotificationSocketService : INotificationSocketService {
    private readonly IHubContext<NotificationHub, INotification> _hubContext;
    public NotificationSocketService(IHubContext<NotificationHub, INotification> hubContext) {
        _hubContext = hubContext;
    }

    public async Task NotifyClientsAsync(PayloadSocket payload) {
        await _hubContext.Clients.All.SendMessage(payload);
    }
}