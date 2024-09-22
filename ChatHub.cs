using Microsoft.AspNetCore.SignalR;

namespace RealTimeChatApp.Api;

public sealed class ChatHub: Hub
{
    public override async Task OnConnectedAsync()
    {
        await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined");
    }
}