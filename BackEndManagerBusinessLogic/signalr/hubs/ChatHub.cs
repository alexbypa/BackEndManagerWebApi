using Microsoft.AspNetCore.SignalR;

namespace BackEndManagerBusinessLogic.signalr.hubs;
public class ChatHub : Hub {
    public async Task SendMessage(string user, string message) {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
    public override Task OnConnectedAsync() {
        return base.OnConnectedAsync(); 
    }
}
