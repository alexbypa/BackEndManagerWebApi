namespace BackEndManagerBusinessLogic.httphelper;
public class httpsClientHelper : IhttpsClientHelper {
    protected readonly IHttpClientFactory clientFactory;
    protected HttpClient httpClient;
    public httpsClientHelper(IHttpClientFactory clientFactory, string clientName) {
        this.clientFactory = clientFactory;
        httpClient = this.clientFactory.CreateClient(clientName);
    }
    public async Task<HttpResponseMessage> sendAsync(string BaseUrl, string Method) {
        Task<HttpResponseMessage> response = httpClient.GetAsync(BaseUrl);
        return await response;
    }
    public httpsClientHelper setTimeout(TimeSpan timeSpan) {
        httpClient.Timeout = timeSpan;
        return this;
    }
    public httpsClientHelper AddHeaders(string KeyName, string KeyValue) {
        httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
        return this;
    }
    public httpsClientHelper addLogger(Action<HttpRequestMessage, HttpResponseMessage, DateTime, DateTime> logAction) {
        var loggingHandler = new HttpLoggingHandler(logAction) {
            InnerHandler = new HttpClientHandler()
        };
        httpClient = new HttpClient(loggingHandler);
        return this;
    }
}
public interface IhttpsClientHelper {

}
