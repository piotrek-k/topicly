using System;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Models.Topics;
using Data.Models.Users;

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
        public string TopicCreatorId { get; set; }
        [ForeignKey(nameof(TopicCreatorId))]
        public ApplicationUser TopicCreator { get; set; }

        /// <summary>
        /// Identyfikator osoby która odpowiedziała na propozycję rozmowy
        /// </summary>
        public string TopicAnswererId { get; set; }
        [ForeignKey(nameof(TopicAnswererId))]
        public ApplicationUser TopicAnswerer { get; set; }
        
        public int TopicId { get; set; }

        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; }

        public string TopicName => Topic?.Name;
        public bool CreatorSeen { get; set; }
        public bool CreatorDeleted { get; set; }
        public bool AnswererSeen { get; set; }
        public bool AnswererDeleted { get; set; }
        
        /// <summary>
        /// Data utworzenia czatu
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        /// <summary>
        /// Data wysłania ostatniej wiadomości przez któregokolwiek użytkownika
        /// </summary>
        public DateTimeOffset LastActivity { get; set; } = DateTimeOffset.Now;
    }
}