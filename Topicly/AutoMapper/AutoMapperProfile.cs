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
            CreateMap<Chat, ChatViewModel>()
                .ForMember(mvm => mvm.TopicCreatorName,
                    opt => opt.MapFrom(src => src.TopicCreator.UserName))
                .ForMember(mvm => mvm.TopicAnswererName,
                    opt => opt.MapFrom(src => src.TopicAnswerer.UserName));
            CreateMap<Message, MessageViewModel>()
                .ForMember(mvm => mvm.SenderHumanReadableName,
                    opt => opt.MapFrom(src => src.Sender.UserName))
                .ForMember(mvm => mvm.SenderUniqueId,
                    opt => opt.MapFrom(src => src.SenderId));
            CreateMap<Topic, TopicViewModel>();
            CreateMap<User_Request_SignUp, ApplicationUser>();
        }
    }
}
