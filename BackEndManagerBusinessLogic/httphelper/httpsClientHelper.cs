using System.Threading.RateLimiting;

namespace BackEndManagerBusinessLogic.httphelper;
public class httpsClientHelper : IhttpsClientHelper {
    protected readonly IHttpClientFactory clientFactory;
    protected HttpClient httpClient;
    protected HttpClientHandler httpLoggingHandler;
    protected RateLimiter rateLimiter;
    public httpsClientHelper(IHttpClientFactory clientFactory, string clientName) {
        this.clientFactory = clientFactory;
        httpClient = this.clientFactory.CreateClient(clientName);
    }
    public async Task<HttpResponseMessage> sendAsync(string BaseUrl, string Method) {
        if (rateLimiter != null) {
            RateLimitLease lease = await rateLimiter.AcquireAsync();
            //while (lease == null || !lease.IsAcquired)
            //    await Task.Delay(100);
        }
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
        if (httpLoggingHandler == null) {
            httpLoggingHandler = new HttpClientHandler() {
                logAction = logAction,
                InnerHandler = new System.Net.Http.HttpClientHandler()
            };
            httpClient = new HttpClient(httpLoggingHandler);
        } else {
            httpLoggingHandler.logAction = logAction;
            httpClient = new HttpClient(httpLoggingHandler);
        }
        return this;
    }
    public httpsClientHelper addRateLimit(httpClientRateLimitOptions rateLimitOptions) {
        if (rateLimitOptions != null)
            rateLimiter = new SlidingWindowRateLimiter(new SlidingWindowRateLimiterOptions {
                AutoReplenishment = rateLimitOptions.AutoReplenishment,
                PermitLimit = rateLimitOptions.PermitLimit,
                QueueLimit = rateLimitOptions.QueueLimit,
                SegmentsPerWindow = rateLimitOptions.SegmentsPerWindow,
                Window = rateLimitOptions.Window
            });
        return this;
    }
}
public interface IhttpsClientHelper {

}
