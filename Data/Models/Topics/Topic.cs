using System;
using System.ComponentModel.DataAnnotations.Schema;
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
        /// Jako jeden ciąg znaków, oddzielone średnikiem
        /// Przykład: tag1;tag2;tag 3;
        /// </summary>
        public string Tags { get; set; } = "";
    }
}