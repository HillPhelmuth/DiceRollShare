using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRollShare.Hubs
{
    public class DieHub : Hub
    {
        public void SendRoll(int result)
        {
            Clients.All.SendAsync("showResult", result);
        }
        public void SendRolling(string roll)
        {
            Clients.All.SendAsync("showRolling", roll);
        }
    }
}
