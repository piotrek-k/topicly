using System;
using System.Threading.Tasks;
using Data;
using Data.Models.Chats;
using Microsoft.AspNetCore.SignalR;

namespace Topicly.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task SendMessage(string name, string message, int chatId)
        {
            // Context.User.Identity powinno zawierać dane wysyłajacego
            
            // TODO: sprawdzić czy wysyłający użytkownik jest członkiem czatu na który wysyła wiadomość

            var receivedMessageAt = DateTimeOffset.Now;
            await _context.Messages.AddAsync(new Message()
            {
                ChatId = chatId,
                Content = message,
                SenderId = "senderId",
                DateOfSending = receivedMessageAt
            });
            await _context.SaveChangesAsync();

            // TODO: wysyłać wiadomość tylko do konkretnego użytkownika
            //Clients.User(userId).SendAsync("message", arg1, arg2)
            
            await Clients.All.SendAsync("sendMessage", name, message, chatId, receivedMessageAt);
        }
    }
}