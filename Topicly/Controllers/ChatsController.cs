using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatsController : Controller

    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ChatsController> _logger;
        private readonly IMapper _mapper;

        public ChatsController(ApplicationDbContext context, ILogger<ChatsController> logger, IMapper mapper)
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
            // TODO: Zwracać tylko czaty należące do użytkownika
            var chats = _context.Chats.Include(x => x.Topic).ToList();
            return chats.Select(x => _mapper.Map<ChatViewModel>(x));
        }
    }
}