using BackEndManagerBusinessLogic.httphelper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace BackEndManagerWebApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class TaskManagerController : ControllerBase {
        private readonly ILogger<TaskManagerController> logger;
        private readonly IHttpClientFactory httpClientFactory;
        public TaskManagerController(ILogger<TaskManagerController> logger, IHttpClientFactory httpClientFactory) {
            this.logger = logger;
            this.httpClientFactory = httpClientFactory;
        }
        [HttpGet(Name = "GetHttpAsync")]
        public async Task<IActionResult> GetHttpAsync() {
            Console.WriteLine("Inizio alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            httpsClientHelper httpsClientHelper = new httpsClientHelper(httpClientFactory);
            Task<HttpResponseMessage> responseMessage2 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=2", "POST");
            Task<HttpResponseMessage> responseMessage4 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=4", "POST");
            Task<HttpResponseMessage> responseMessage5 = httpsClientHelper.sendAsync("https://reqres.in/api/users?delay=5", "POST");
            HttpResponseMessage httpResponseMessage2 = await responseMessage2;
            HttpResponseMessage httpResponseMessage4 = await responseMessage4;
            HttpResponseMessage httpResponseMessage5 = await responseMessage5;
            List<string> content = [
                await httpResponseMessage2.Content.ReadAsStringAsync(),
                await httpResponseMessage4.Content.ReadAsStringAsync(),
                await httpResponseMessage5.Content.ReadAsStringAsync()
                ];
            Console.WriteLine("Fine alle {0}", DateTime.Now.ToString("mm:ss.fff"));
            return Ok(string.Join("\n", content.ToArray()));
        }
    }
}
