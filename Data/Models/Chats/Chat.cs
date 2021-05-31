using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Models.Topics;

namespace Data.Models.Chats
{
    /// <summary>
    /// Rozmowa pomiędzy dwoma użytkownikami
    /// </summary>
    public class Chat
    {
        public int Id { get; set; }

        /// <summary>
        /// Identyfikator osoby proponującej temat
        /// </summary>
        public string TopicCreator { get; set; }

        /// <summary>
        /// Identyfikator osoby która odpowiedziała na propozycję rozmowy
        /// </summary>
        public string TopicAnswerer { get; set; }

        public int TopicId { get; set; }

        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; }

        public string TopicName => Topic?.Name;

        public List<ChatParticipant> ChatParticipants { get; set; }
        public List<Message> Messages { get; set; }
    }
}