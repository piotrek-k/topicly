namespace Topicly.ViewModels
{
    public class ChatViewModel
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Identyfikator osoby proponującej temat
        /// </summary>
        public string TopicCreatorName { get; set; }
        /// <summary>
        /// Identyfikator osoby która odpowiedziała na propozycję rozmowy
        /// </summary>
        public string TopicAnswererName { get; set; }
        
        /// <summary>
        /// Temat rozmowy
        /// </summary>
        public string TopicName { get; set; }
    }
}