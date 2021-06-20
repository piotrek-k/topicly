using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Data.Models.Users;

namespace Data.Models.Topics
{
    /// <summary>
    /// Temat proponowany przez użytkownika
    /// </summary>
    public class Topic
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
        
        [ForeignKey(nameof(CreatedById))]
        public ApplicationUser CreatedBy { get; set; }
        
        /// <summary>
        /// Data utworzenia tematu
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        
        /// <summary>
        /// Moment w którym temat ulega przedawnieniu
        /// </summary>
        public DateTimeOffset ExpiryDate { get; set; }

        /// <summary>
        /// Jako jeden ciąg znaków, oddzielone średnikiem
        /// Przykład: tag1;tag2;tag 3;
        /// </summary>
        public string TagsAsString
        {
            get
            {
                return String.Join(';', Tags?.Select(x=>x.Name) ?? Array.Empty<string>());
            }
        }

        /// <summary>
        /// Lista tagów jako rekordów w bazie danych
        /// </summary>
        public ICollection<Tag> Tags { get; set; }
        public List<TopicTag> TopicTags { get; set; }
    }
}