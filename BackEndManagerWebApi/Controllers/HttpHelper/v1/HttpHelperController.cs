using Asp.Versioning;
using BackEndManagerBusinessLogic.httphelper;
using BackEndManagerBusinessLogic.polly;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BackEndManagerWebApi.Controllers.HttpHelper.v1 {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class HttpHelperController : ControllerBase {
        private readonly IHttpClientFactory httpClientFactory;
        List<httpClientOptions> httpConfig;
        public HttpHelperController(IHttpClientFactory httpClientFactory, IOptions<List<httpClientOptions>> httpoptions) {
            this.httpClientFactory = httpClientFactory;
            httpConfig = httpoptions.Value;
        } 
        [HttpPost(Name = "GetHttpAsync")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> GetHttpAsync(string clientName, int SecondTimeout) {
            Console.WriteLine("Inizio alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            httpsClientHelper httpsClientHelper = new httpsClientHelper(httpClientFactory, clientName);
            
            Task<HttpResponseMessage> responseMessage2 = httpsClientHelper
                .addTimeout(TimeSpan.FromSeconds(SecondTimeout))
                .addLogger((request, response, start, stop) => Console.WriteLine($"REQ {request.RequestUri}, STATUS {response.StatusCode}, FROM {start} TO : {stop}"))
                .addHeaders("User-Agent", "HttpClientFactory-Sample")
                .addRateLimit(httpConfig.FirstOrDefault(item => item.Name.Equals(clientName))?.RateLimitOptions)
                .sendAsync("https://httpbin.org/status/429");

            PollyRetryPolicy retryPolicy = new PollyRetryPolicy();
            responseMessage2 = retryPolicy.ExecuteAsync<HttpResponseMessage>(async () => {
                return await responseMessage2;
                }, 
                (response) => response.StatusCode == System.Net.HttpStatusCode.TooManyRequests, 
                (result, timespan, retry, context) => { });

            //HttpResponseMessage responseMessage4 = await httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=4");
            HttpResponseMessage responseMessage5 = await httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=3");
            HttpResponseMessage responseMessage = await httpsClientHelper.addHeaders("User-Agent", "HttpClientFactory-Sample").sendAsync("https://api.github.com/");

            //Task<HttpResponseMessage> responseMessage2 = httpsClientHelper
            //    .setTimeout(TimeSpan.FromSeconds(SecondTimeout))
            //    .addLogger((request, response, start, stop) => Console.WriteLine($"REQ {request.RequestUri}, STATUS {response.StatusCode}, FROM {start} TO : {stop}"))
            //    .AddHeaders("User-Agent", "HttpClientFactory-Sample")
            //    .addRateLimit(httpConfig.FirstOrDefault(item => item.Name.Equals(clientName)).RateLimitOptions)
            //    .sendAsync("https://reqres.in/api/users?delay=2", "POST");
            //Task<HttpResponseMessage> responseMessage4 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=4", "POST");
            //Task<HttpResponseMessage> responseMessage5 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=3", "POST");
            //Task<HttpResponseMessage> responseMessage = httpsClientHelper.AddHeaders("User-Agent", "HttpClientFactory-Sample").sendAsync("https://api.github.com/", "POST");

            //HttpResponseMessage httpResponseMessage2 = await responseMessage2;
            //HttpResponseMessage httpResponseMessage4 = await responseMessage4;
            //HttpResponseMessage httpResponseMessage5 = await responseMessage5;
            //HttpResponseMessage httpResponseMessage = await responseMessage;

            var response2 = await responseMessage2;
            List<string> content = [
                await response2.Content.ReadAsStringAsync(),
                
                await responseMessage5.Content.ReadAsStringAsync(),
                await responseMessage.Content.ReadAsStringAsync()
                ];
            Console.WriteLine("Fine alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            return Ok(string.Join("\n", content.ToArray()));
        }
    }
}
