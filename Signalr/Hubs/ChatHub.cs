using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Signalr.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user,string message)
        {
             await Clients.All.SendAsync("RecieveMessage",user,message,
                 DateTime.Now.ToString("dddd, dd MMMM yyyy"));

        }
    }
}
