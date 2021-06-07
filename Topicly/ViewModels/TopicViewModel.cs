namespace Topicly.ViewModels
{
    /// <summary>
    /// Temat proponowany przez użytkownika
    /// </summary>
    public class TopicViewModel
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Teza utworzona przez użytkownika. Stwierdzenie będące punktem startowym rozmowy
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Identyfikator użytkownika który utworzył ten temat
        /// </summary>
        public string CreatedById { get; set; }
        
        public string CreatedByName { get; set; }
    }
}