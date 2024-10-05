using Asp.Versioning;
using BackEndManagerBusinessLogic.signalr.hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BackEndManagerWebApi.Controllers.signalr {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class signalrController : ControllerBase {
        private readonly IHubContext<ChatHub> _hubContext;
        public signalrController(IHubContext<ChatHub> hubContext) {
            _hubContext = hubContext;
        }
        [HttpGet(Name = "sample")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> sample(string username, string message) {
            await Task.Delay(100);
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", username, message);
            return Ok();
        }
    }
}
