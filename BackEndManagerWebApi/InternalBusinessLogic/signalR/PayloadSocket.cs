using BackEndManagerBusinessLogic.httphelper;
using BackEndManagerBusinessLogic.signalr.hubs;

namespace BackEndManagerWebApi.InternalBusinessLogic.signalR;
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
                NotificationType = "Test ReqRes",
                Message = new {
                    Sport = "Calcio",
                    Category = "Italy",
                    Tournament = "Serie A",
                    AdditionalInfo = content
                }
            });
        }
    }
}