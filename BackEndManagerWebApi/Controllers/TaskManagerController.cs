using Asp.Versioning;
using BackEndManagerBusinessLogic.httphelper;
using Microsoft.AspNetCore.Mvc;

namespace BackEndManagerWebApi.Controllers {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class MyControllerV2 : ControllerBase {

        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult Get() => Ok("API Version 1.0");
    }

    [ApiController]
    [ApiVersion("1.1")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class MyControllerV11 : ControllerBase {

        [MapToApiVersion("1.1")]
        [HttpGet]
        public IActionResult Get() => Ok("API Version 1.1");
    }

    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class TaskManagerController : ControllerBase {
        private readonly ILogger<TaskManagerController> logger;
        private readonly IHttpClientFactory httpClientFactory;
        public TaskManagerController(ILogger<TaskManagerController> logger, IHttpClientFactory httpClientFactory) {
            this.logger = logger;
            this.httpClientFactory = httpClientFactory;
        }
        [HttpGet(Name = "YieldSample")]
        [MapToApiVersion("2.0")]
        public async Task<IActionResult> YieldSample() {
            int totRes = 0;
            string wordtomatch = "Task";
            await foreach (var word in MatchCountFromEndpoint("https://learn.microsoft.com/it-it/dotnet/csharp/asynchronous-programming/async-return-types", wordtomatch)) {
                totRes++;
            }
            return Ok(totRes);
        }
        [HttpOptions(Name = "switchSample")]
        [MapToApiVersion("2.0")]
        public IActionResult switchSample(int grade) {
             
            string result = grade switch {
                < 20 => "Excellent",
                > 20 => "Good",
                _ => ""
            };
            return Ok(result);
        }
        [HttpPost(Name = "GetHttpAsync")]
        [MapToApiVersion("2.0")]
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

        //TODO: esempio yield finalmente chiaro !!!! grazie chatgpt !!
        private async IAsyncEnumerable<string> MatchCountFromEndpoint(string url, string match) {
            Task<string> data;
            using (HttpClient client = new HttpClient()) {
                data = client.GetStringAsync(url);
                using var readStream = new StringReader(await data);
                string? line = readStream.ReadLine();
                while (line != null) {
                    foreach (string word in line.Split(' ', StringSplitOptions.RemoveEmptyEntries)) {
                        if (word.Equals(match, StringComparison.InvariantCultureIgnoreCase))
                            yield return word;
                    }
                    line = readStream.ReadLine();
                }
            }
        }
    }
}
