using System;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models.Chats;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
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
            await UpdateChatSubscriptions(null, null);

            await base.OnConnectedAsync();
        }

        /// <summary>
        /// Powiadom aplikację kliencką innego użytkownika, że dodano go do nowego czatu
        /// </summary>
        /// <param name="otherParticipantId"></param>
        /// <param name="topic"></param>
        /// <returns></returns>
        public async Task UpdateChatSubscriptions(string otherParticipantId, string topic)
        {
            var senderId = Context.UserIdentifier;

            // Pobieram listę czatów użytkownika i automatycznie nasłuchuję aktualizacji każdego z nich
            foreach (var chat in _context.Chats.Where(x =>
                x.TopicCreatorId == Context.UserIdentifier || x.TopicAnswererId == Context.UserIdentifier))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, ConstructChatGroupId(chat.Id));
                _logger.LogInformation($"Added user {Context.UserIdentifier} to group {ConstructChatGroupId(chat.Id)}");
            }

            if (otherParticipantId != null)
            {
                if (Context.User != null)
                    await Clients.Users(otherParticipantId)
                        .SendAsync("requestChatListUpdate", Context.User.Identity?.Name, topic);
            }
            // else
            // {
            //     throw new HubException($"otherParticipantId jest puste");
            // }
        }

        /// <summary>
        /// Wyślij wiadomość o treści `message` do czatu `chatId`
        /// </summary>
        public async Task SendMessage(string message, int chatId)
        {
            var chatInDb = await _context.Chats.FindAsync(chatId);
            var senderId = Context.UserIdentifier;
            if (Context.User?.Identity != null)
            {
                var senderName = Context.User.Identity.Name;

                if (chatInDb == null)
                {
                    throw new HubException($"Nie ma takiego czatu: chatId = ({chatId})");
                }

                if (chatInDb.TopicAnswererId != senderId && chatInDb.TopicCreatorId != senderId)
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

                UpdateChat(chatInDb, senderId);

                await _context.SaveChangesAsync();

                await Clients.Group(ConstructChatGroupId(chatId))
                    .SendAsync("sendMessage", senderId, senderName, message, chatId, receivedMessageAt);
            }
            else
            {
                throw new Exception("Brak danych o użytkowniku");
            }
        }

        private void UpdateChat(Chat chat, string senderId)
        {
            if (senderId == chat.TopicCreatorId)
            {
                chat.AnswererSeen = false;
            }
            else
            {
                chat.CreatorSeen = false;
            }

            // aktualizacja daty ostatniej aktywności
            chat.LastActivity = DateTimeOffset.Now;
        }

        private string ConstructChatGroupId(int id)
        {
            return "chat_" + id;
        }
    }
}