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
    }
}