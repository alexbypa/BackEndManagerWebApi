using BackEndManagerBusinessLogic.httphelper;
using BackEndManagerBusinessLogic.signalr.hubs;

namespace BackEndManagerWebApi.InternalBusinessLogic.signalR;
public class InfoPayloadDownloadReqRes {
    public int ContentLength { get; set; }
    public int HttpStatus { get; set; }
    public string Content { get; set; }
}
public class yourBusinessLogic {
    private readonly INotificationSocketService _notificationService;
    private readonly IHttpClientFactory _httpClientFactory;
    public yourBusinessLogic(INotificationSocketService notificationService, IHttpClientFactory httpClientFactory) {
        _notificationService = notificationService;
        _httpClientFactory = httpClientFactory;
    }
    public async Task SendNotification(string httpClientName) {
        httpsClientHelper httpsclienthelper = new httpsClientHelper(_httpClientFactory, httpClientName);
        HttpResponseMessage httpResponseMessage = await httpsclienthelper.sendAsync("https://reqres.in/api/users?delay=5");
        if (httpResponseMessage.IsSuccessStatusCode) {
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            await _notificationService.NotifyClientsAsync(new PayloadSocket {
                NotificationType = "Test ReqRes",
                Message = new  InfoPayloadDownloadReqRes{
                    ContentLength = content.Length,
                    HttpStatus = (int)httpResponseMessage.StatusCode,
                    Content = content
                }
            });
        }
    }
}