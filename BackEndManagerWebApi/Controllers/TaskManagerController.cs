using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace BackEndManagerWebApi.Controllers {
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
