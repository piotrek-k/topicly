using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Message
    {
        public long Id { get; set; }
        
        public long ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
        
        public DateTimeOffset DateOfSending { get; set; }
        public string Content { get; set; }
    }
}