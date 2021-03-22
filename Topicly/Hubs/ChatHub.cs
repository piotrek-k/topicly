using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Topicly.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            // Context.User.Identity powinno zawierać dane wysyłajacego
            
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}