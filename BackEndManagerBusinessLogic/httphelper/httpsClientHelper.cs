namespace BackEndManagerBusinessLogic.httphelper;
public class httpsClientHelper : IhttpsClientHelper {
    protected readonly IHttpClientFactory clientFactory;
    protected readonly HttpClient httpClient;
    public httpsClientHelper(IHttpClientFactory clientFactory) {
        this.clientFactory = clientFactory;
        httpClient = this.clientFactory.CreateClient();
    }
    public async Task<HttpResponseMessage> sendAsync(string BaseUrl, string Method) {
        Task<HttpResponseMessage> response = httpClient.GetAsync(BaseUrl);
        return await response;
    }
}
public interface IhttpsClientHelper {

}
