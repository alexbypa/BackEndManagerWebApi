using BackEndManagerBusinessLogic.httphelper;
using Microsoft.AspNetCore.SignalR;
using System.Net.Mime;

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


public interface INotificationService {
    Task NotifyClientsAsync(PayloadSocket payload);
}
public class NotificationService : INotificationService {
    private readonly IHubContext<NotificationHub, INotification> _hubContext;

    public NotificationService(IHubContext<NotificationHub, INotification> hubContext) {
        _hubContext = hubContext;
    }

    public async Task NotifyClientsAsync(PayloadSocket payload) {
        await _hubContext.Clients.All.SendMessage(payload);
    }
}

public class yourBusinessLogic {
    private readonly INotificationService _notificationService;
    private readonly IHttpClientFactory _httpClientFactory;
    public yourBusinessLogic(INotificationService notificationService, IHttpClientFactory httpClientFactory) {
        _notificationService = notificationService;
        _httpClientFactory = httpClientFactory;
    }
    public async Task PerformOperation(string httpClientName) {
        httpsClientHelper httpsclienthelper = new httpsClientHelper(_httpClientFactory, httpClientName);
        HttpResponseMessage httpResponseMessage = await httpsclienthelper.sendAsync("https://reqres.in/api/users?delay=5");
        if (httpResponseMessage.IsSuccessStatusCode) {
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            await _notificationService.NotifyClientsAsync(new PayloadSocket {
                Message = content,
                NotificationType = "Test ReqRes"
            });
        }
    }
}