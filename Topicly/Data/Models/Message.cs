using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Topicly.Data
{
    public class Message
    {
        public int Id { get; set; }
        
        public int ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
        
        public DateTimeOffset DateOfSending { get; set; }
        public string Content { get; set; }
    }
}