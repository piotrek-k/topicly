using System;

namespace Topicly.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }

        public int ChatId { get; set; }
        
        public string SenderUniqueId { get; set; }
        public string SenderHumanReadableName { get; set; }

        /// <summary>
        /// Data wysłania wiadomości
        /// </summary>
        public DateTimeOffset DateOfSending { get; set; }
        /// <summary>
        /// Treść wiadomości
        /// </summary>
        public string Content { get; set; }
    }
}