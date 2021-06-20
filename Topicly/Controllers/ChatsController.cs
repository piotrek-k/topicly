using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Models.Chats;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Controllers.BaseClasses;
using Topicly.RequestsAndResponsesModels;
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
        public async Task<IEnumerable<ChatViewModel>> GetChatsForUser()
        {
            var userId = GetCurrentUserId();

            var chats = await _context.Chats
                .Include(x => x.Topic)
                .Include(x => x.TopicAnswerer)
                .Include(x => x.TopicCreator)
                .Where(x =>
                    x.TopicAnswererId == userId && x.AnswererDeleted == false ||
                    x.TopicCreatorId == userId && x.CreatorDeleted == false)
                .OrderByDescending(x=>x.LastActivity)
                .ToListAsync();

            return chats.Select(x => _mapper.Map<ChatViewModel>(x));
        }

        [HttpPost("MarkChatAsSeen")]
        public async Task<IActionResult> MarkChatAsSeen(Chat_Request_MarkChatAsSeen req)
        {
            var userId = GetCurrentUserId();
            var chat = await _context.Chats.FindAsync(req.ChatId);

            if (chat == null)
            {
                return BadRequest("Chat of ID does not exist");
            }

            var isUserParticipantOfChat = chat.TopicCreatorId == userId || chat.TopicAnswererId == userId;

            if (isUserParticipantOfChat == false)
            {
                return Unauthorized($"User is not a participant of the chat {req.ChatId}");
            }

            if (userId == chat.TopicCreatorId)
            {
                chat.CreatorSeen = true;
            }
            else
            {
                chat.AnswererSeen = true;
            }

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("DeleteChat")]
        public async Task<IActionResult> DeleteChat(Chat_Request_DeleteChat req)
        {
            var userId = GetCurrentUserId();
            var chat = await _context.FindAsync<Chat>(req.Id);

            if (chat == null)
            {
                return BadRequest($"Chat {req.Id} does not exist");
            }

            if (userId == chat.TopicCreatorId)
            {
                chat.CreatorDeleted = true;
            }
            else if (userId == chat.TopicAnswererId)
            {
                chat.AnswererDeleted = true;
            }
            else
            {
                return BadRequest($"User {userId} is not a participant of chat {req.Id}");
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}