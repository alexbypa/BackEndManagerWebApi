using Asp.Versioning;
using BackEndManagerBusinessLogic.signalr;
using BackEndManagerBusinessLogic.signalr.hubs;
using BackEndManagerWebApi.businesslogic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace BackEndManagerWebApi.Controllers.signalr {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class signalrController : ControllerBase {
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IHubContext<NotificationHub, INotification> _hubNotification;
        //private readonly INotifierADMManger _notifierADMManger;
        //private readonly ClientNotifierADMManger _clientNotifier;
        public signalrController(
            IHubContext<ChatHub> hubContext
            ,IHubContext<NotificationHub
            ,INotification> hubNotification
            //,INotifierADMManger notifierADMManger
            //,IHubContext<NotificationHub> hubContext
            ) {
            _hubContext = hubContext;
            _hubNotification = hubNotification;
        }
        [HttpGet(Name = "sample", Order = 1)]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> sample(string username, string message) {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", username, message);
            return Ok();
        }
        [HttpPost(Name = "samplewithtype", Order = 2)]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> samplewithtype(string NotificationType, string Message) {
            var payload = new PayloadSocket {
                NotificationType = NotificationType,
                Message = Message
            };
            string message = JsonConvert.SerializeObject(payload, Formatting.Indented);
            await _hubNotification.Clients.All.SendMessage(payload);
            return Ok(message);
        }
        [HttpPut(Name = "samplewithtypeObserver", Order = 2)]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> samplewithtypeObserver(string NotificationType, string Message) {
            //TODO:
            var payload = new PayloadSocket {
                NotificationType = NotificationType,
                Message = Message
            };
            string message = JsonConvert.SerializeObject(payload, Formatting.Indented);
            await _hubNotification.Clients.All.SendMessage(payload);
            return Ok(message);
        }
    }
}
