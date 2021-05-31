using System;
using Data.Models.Users;
    
namespace Data.Models.Chats
{
    /// <summary>
    /// Pojedyncza wiadomość wysłana od użytkownika A do B
    /// </summary>
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTimeOffset DateOfSending { get; set; }
        public int ChatId { get; set; }
        public string UserId { get; set; }

        public Chat Chat { get; set; }
        public ApplicationUser User { get; set; }
    }
}