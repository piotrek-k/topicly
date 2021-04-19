using System;
using System.ComponentModel.DataAnnotations.Schema;
using Topicly.ViewModels;

namespace Topicly.Data.Models.Chat
{
    /// <summary>
    /// Pojedyncza wiadomość wysłana od użytkownika A do B
    /// </summary>
    public class Message
    {
        public int Id { get; set; }

        public int ChatId { get; set; }
        [ForeignKey(nameof(ChatId))] public Chat Chat { get; set; }

        public DateTimeOffset DateOfSending { get; set; }
        public string Content { get; set; }

        public MessageViewModel ToViewModel()
        {
            return new()
            {
                Id = Id,
                ChatId = ChatId,
                DateOfSending = DateOfSending,
                Content = Content
            };
        }
    }
}