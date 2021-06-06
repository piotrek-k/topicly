using System;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models.Chats;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace Topicly.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ChatHub> _logger;

        public ChatHub(ApplicationDbContext context, ILogger<ChatHub> logger)
        {
            _context = context;
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            // Pobieram listę czatów użytkownika i automatycznie nasłuchuję aktualizacji każdego z nich
            foreach (var chat in _context.Chats.Where(x =>
                x.TopicCreator == Context.UserIdentifier || x.TopicAnswerer == Context.UserIdentifier))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, ConstructChatGroupId(chat.Id));
                _logger.LogInformation($"Added user {Context.UserIdentifier} to group {ConstructChatGroupId(chat.Id)}");
            }

            await base.OnConnectedAsync();
        }

        public async Task SendMessage(string message, int chatId)
        {
            var chatInDb = await _context.Chats.FindAsync(chatId);
            var senderId = Context.UserIdentifier;

            if (chatInDb == null)
            {
                throw new HubException($"Nie ma takiego czatu: chatId = ({chatId})");
            }

            if (chatInDb.TopicAnswerer != senderId && chatInDb.TopicCreator != senderId)
            {
                throw new HubException($"Użytkownik nie ma uprawnień do czatu: chatId = ({chatId})");
            }

            var receivedMessageAt = DateTimeOffset.Now;
            await _context.Messages.AddAsync(new Message()
            {
                ChatId = chatId,
                Content = message,
                SenderId = Context.UserIdentifier,
                DateOfSending = receivedMessageAt
            });
            await _context.SaveChangesAsync();

            await Clients.Group(ConstructChatGroupId(chatId))
                .SendAsync("sendMessage", senderId, message, chatId, receivedMessageAt);
        }

        private string ConstructChatGroupId(int id)
        {
            return "chat_" + id;
        }
    }
}