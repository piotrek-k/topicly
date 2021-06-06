using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Controllers.BaseClasses;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ChatsController : TopiclyControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ChatsController> _logger;
        private readonly IMapper _mapper;

        public ChatsController(UserManager<ApplicationUser> userManager, ApplicationDbContext context,
            ILogger<ChatsController> logger, IMapper mapper)
            : base(userManager)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Lista czatów dla zalogowanego użytkownika
        /// </summary>
        [HttpGet("GetAllForCurrentUser")]
        public IEnumerable<ChatViewModel> GetChatsForUser()
        {
            var chats = _context.Chats
                .Include(x => x.Topic)
                .Where(x => x.TopicAnswerer == GetCurrentUserId() || x.TopicCreator == GetCurrentUserId())
                .ToList();
            return chats.Select(x => _mapper.Map<ChatViewModel>(x));
        }
    }
}