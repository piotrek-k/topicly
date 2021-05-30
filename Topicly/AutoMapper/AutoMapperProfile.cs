using AutoMapper;
using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;
using Topicly.RequestsAndResponsesModels;
using Topicly.ViewModels;

namespace Topicly.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Chat, ChatViewModel>();
            CreateMap<Message, MessageViewModel>();
            CreateMap<Topic, TopicViewModel>();
            CreateMap<User_Request_SignUp, ApplicationUser>();
        }
    }
}
