using System;
using System.Collections.Generic;

namespace Topicly.ViewModels
{
    /// <summary>
    /// Klasa przechowująca dane konieczne do utowrzenia nowego tematu
    /// </summary>
    public class TopicCreationViewModel
    {
        /// <summary>
        /// Zawartość tematu; Stwierdzenie będące punktem startowym rozmowy
        /// </summary>
        public string Content { get; set; }
        
        /// <summary>
        /// Lista nazw tagów powiązanych z tematem
        /// </summary>
        public List<string> Tags { get; set; }
        
        /// <summary>
        /// Moment w którym temat ulega przedawnieniu
        /// </summary>
        public DateTimeOffset ExpiryDate { get; set; }
    }
}