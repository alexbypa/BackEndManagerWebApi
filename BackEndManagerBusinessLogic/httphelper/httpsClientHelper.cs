using System.Threading.RateLimiting;

namespace BackEndManagerBusinessLogic.httphelper;
public class httpsClientHelper : IhttpsClientHelper {
    protected readonly IHttpClientFactory clientFactory;
    protected HttpClient httpClient;
    protected HttpClientHandler httpLoggingHandler;
    protected RateLimiter rateLimiter;
    private Func<HttpResponseMessage, bool> RetryCondition;
    public httpsClientHelper(IHttpClientFactory clientFactory, string clientName) {
        this.clientFactory = clientFactory;
        httpClient = this.clientFactory.CreateClient(clientName);
    }
    public httpsClientHelper(IHttpClientFactory clientFactory, string clientName, Func<HttpResponseMessage, bool> RetryCondition) {
        this.clientFactory = clientFactory;
        httpClient = this.clientFactory.CreateClient(clientName);
        this.RetryCondition = RetryCondition;
    }
    public async Task<HttpResponseMessage> sendAsync(string BaseUrl) {
        if (rateLimiter != null) {
            RateLimitLease lease = await rateLimiter.AcquireAsync();
        }        
        Task<HttpResponseMessage> response = httpClient.GetAsync(BaseUrl);
        return await response;
    }
    public httpsClientHelper addTimeout(TimeSpan timeSpan) {
        httpClient.Timeout = timeSpan;
        return this;
    }
    public httpsClientHelper addHeaders(string KeyName, string KeyValue) {
        httpClient.DefaultRequestHeaders.Add(KeyName, KeyValue);
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
public interface IhttpsClientHelper {}
