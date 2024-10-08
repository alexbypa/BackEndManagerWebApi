﻿using Asp.Versioning;
using BackEndManagerBusinessLogic.httphelper;
using BackEndManagerBusinessLogic.polly;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BackEndManagerWebApi.Controllers.HttpHelper.v2 {
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class HttpHelperController : Controller {
        private readonly IHttpClientFactory httpClientFactory;
        List<httpClientOptions> httpConfig;
        public HttpHelperController(IHttpClientFactory httpClientFactory, IOptions<List<httpClientOptions>> httpoptions) {
            this.httpClientFactory = httpClientFactory;
            httpConfig = httpoptions.Value;
        }
        [HttpPost(Name = "GetHttpAsync")]
        public async Task<IActionResult> GetHttpAsync(int retryCondition) {
            Console.WriteLine("Inizio alle {0}", DateTime.Now.ToString("HH:mm:ss.fff"));
            httpsClientHelper httpsClientHelper = new httpsClientHelper(httpClientFactory, "reqres");

            Task<HttpResponseMessage> responseMessage2 = httpsClientHelper
                .addTimeout(TimeSpan.FromSeconds(5))
                .sendAsync("https://httpbin.org/status/429");

            PollyRetryPolicy retryPolicy = new PollyRetryPolicy();
            responseMessage2 = retryPolicy.ExecuteAsync<HttpResponseMessage>(async () => {
                return await httpsClientHelper
                    .addLogger((req, res, start, stop) => Console.WriteLine($":::::::::::CHIAMO {req}"))
                    .sendAsync($"https://httpbin.org/status/{retryCondition}");
            },
                (response) => (int)response.StatusCode == retryCondition,
                (result, timeSpan, retryCount, context) => {
                    if (result.Exception != null)
                        Console.WriteLine(result.Exception.ToString());
                    else
                        Console.WriteLine(result.Result.ToString());
                    Console.WriteLine($"Tentativo fallito {retryCount}. Ritenterò tra {timeSpan.TotalSeconds} secondi.");
                }
            );
            var response2 = await responseMessage2;
            Console.WriteLine("Fine alle {0}", DateTime.Now.ToString("HH:mm:ss.fff"));
            return Ok();
        }
    }
}
