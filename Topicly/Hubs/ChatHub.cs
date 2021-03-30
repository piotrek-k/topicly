using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Topicly.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            // Context.User.Identity powinno zawierać dane wysyłajacego
            
            // TODO: zapisać wiadomość do bazy danych

            // TODO: wysyłać wiadomość tylko do konkretnego użytkownika
            //Clients.User(userId).SendAsync("message", arg1, arg2)
            
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}