using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using BackEndManagerBusinessLogic.httphelper;

namespace BackEndManagerWebApi.Controllers.HttpHelper.v1 {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class HttpHelperController : ControllerBase {
        private readonly IHttpClientFactory httpClientFactory;
        public HttpHelperController(IHttpClientFactory httpClientFactory) {
            this.httpClientFactory = httpClientFactory;
        } 
        [HttpPost(Name = "GetHttpAsync")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> GetHttpAsync(string clientName, int SecondTimeout) {
            Console.WriteLine("Inizio alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            httpsClientHelper httpsClientHelper = new httpsClientHelper(httpClientFactory, clientName);
            Task<HttpResponseMessage> responseMessage2 = httpsClientHelper
                .setTimeout(TimeSpan.FromSeconds(SecondTimeout))
                .addLogger((request, response, start, stop) => Console.WriteLine($"hai chiamato {request.RequestUri}, la risposta è stata {response.StatusCode}, inizio {start} fine : {stop}"))
                .AddHeaders("User-Agent", "HttpClientFactory-Sample")
                .sendAsync("https://reqres.in/api/users?delay=2", "POST");
            Task<HttpResponseMessage> responseMessage4 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=4", "POST");
            Task<HttpResponseMessage> responseMessage5 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=5", "POST");
            Task<HttpResponseMessage> responseMessage = httpsClientHelper
                .AddHeaders("User-Agent", "HttpClientFactory-Sample")
                .sendAsync("https://api.github.com/", "POST");
            HttpResponseMessage httpResponseMessage2 = await responseMessage2;
            HttpResponseMessage httpResponseMessage4 = await responseMessage4;
            HttpResponseMessage httpResponseMessage5 = await responseMessage5;
            HttpResponseMessage httpResponseMessage = await responseMessage;
            List<string> content = [
                await httpResponseMessage2.Content.ReadAsStringAsync(),
                await httpResponseMessage4.Content.ReadAsStringAsync(),
                await httpResponseMessage5.Content.ReadAsStringAsync(),
                await httpResponseMessage.Content.ReadAsStringAsync()
                ];
            Console.WriteLine("Fine alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            return Ok(string.Join("\n", content.ToArray()));
        }
    }
}
