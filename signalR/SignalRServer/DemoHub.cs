using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.SignalRServer
{
    public class DemoHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            Console.WriteLine($"{user}:{message}.");
            return Clients.All.SendMessage("ReceiveMessage",user, message);
        }
    }
}
