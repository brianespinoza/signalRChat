using Microsoft.AspNetCore.SignalR;
namespace SignalRChat.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string sendMessage, string user)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, sendMessage);
    }
}