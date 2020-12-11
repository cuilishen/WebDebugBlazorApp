using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.SignalR;

namespace WebDebugBlazorApp.Shared
{
    public class WebDebugHub:Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}
