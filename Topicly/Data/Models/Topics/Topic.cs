using System;
using System.ComponentModel.DataAnnotations.Schema;
using Topicly.ViewModels;

namespace Topicly.Data.Models.Topics
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
        public string CreatedBy { get; set; }

        public TopicViewModel ToViewModel()
        {
            return new()
            {
                Id = Id,
                Name = Name,
                CreatedBy = CreatedBy
            };
        }

        public void UpdateFromViewModel(TopicViewModel vm)
        {
            Name = vm.Name;
        }
    }
}