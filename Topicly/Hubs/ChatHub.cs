using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Topicly.Data;
using Topicly.Data.Models.Chat;

namespace Topicly.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationContext _context;

        public ChatHub(ApplicationContext context)
        {
            _context = context;
        }
        
        public async Task SendMessage(string name, string message, int chatId)
        {
            // Context.User.Identity powinno zawierać dane wysyłajacego
            
            // TODO: sprawdzić czy wysyłający użytkownik jest członkiem czatu na który wysyła wiadomość
            
            await _context.Messages.AddAsync(new Message()
            {
                ChatId = chatId,
                Content = message,
                SenderId = "senderId",
                DateOfSending = DateTimeOffset.Now
            });
            await _context.SaveChangesAsync();

            // TODO: wysyłać wiadomość tylko do konkretnego użytkownika
            //Clients.User(userId).SendAsync("message", arg1, arg2)
            
            await Clients.All.SendAsync("sendMessage", name, message, chatId);
        }
    }
}