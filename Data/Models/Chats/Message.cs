using System;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Models.Users;

namespace Data.Models.Chats
{
    /// <summary>
    /// Pojedyncza wiadomość wysłana od użytkownika A do B
    /// </summary>
    public class Message
    {
        public int Id { get; set; }

        public int ChatId { get; set; }

        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }

        public DateTimeOffset DateOfSending { get; set; }

        public string Content { get; set; }
        
        public string SenderId { get; set; }
        [ForeignKey(nameof(SenderId))]
        public ApplicationUser Sender { get; set; }
    }
}