using AutoMapper;
using Data.Models.Chats;
using Data.Models.Topics;
using Topicly.ViewModels;

namespace Topicly.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Chat, ChatViewModel>();
            CreateMap<MessageViewModel, MessageViewModel>();
            CreateMap<Topic, TopicViewModel>();
        }
    }
}
