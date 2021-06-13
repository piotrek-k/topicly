using System;

namespace Topicly.ViewModels
{
    public class ChatViewModel
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Identyfikator osoby proponującej temat
        /// </summary>
        public string TopicCreatorId { get; set; }
        /// <summary>
        /// Nazwa użytkownika proponującego temat
        /// </summary>
        public string TopicCreatorName { get; set; }
       
        
        /// <summary>
        /// Identyfikator osoby która odpowiedziała na propozycję rozmowy
        /// </summary>
        public string TopicAnswererId { get; set; }
        /// <summary>
        /// Nazwa użytkownika który odpowiedział na propozycję rozmowy
        /// </summary>
        public string TopicAnswererName { get; set; }
        
        /// <summary>
        /// Temat rozmowy
        /// </summary>
        public string TopicName { get; set; }
        public bool CreatorSeen { get; set; }
        public bool AnswererSeen { get; set; }
        
        /// <summary>
        /// Data utworzenia czatu
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        /// <summary>
        /// Data wysłania ostatniej wiadomości przez któregokolwiek użytkownika
        /// </summary>
        public DateTimeOffset LastActivity { get; set; }
    }
}