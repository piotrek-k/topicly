using System.ComponentModel.DataAnnotations.Schema;
using Topicly.Data.Models.Topics;
using Topicly.ViewModels;

namespace Topicly.Data.Models.Chat
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

        public ChatViewModel ToViewModel()
        {
            return new()
            {
                Id = Id,
                // TODO: Nie ma jak pobrać nazw użytkownika na razie. Wrzucam przykładowe dane
                TopicCreatorName = "Alice",
                TopicAnswererName = "Bob",
                TopicName = TopicName
            };
        }
    }
}