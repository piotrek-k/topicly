using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
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
    public class TopicsController : TopiclyControllerBase
    {
        private ApplicationDbContext _context;
        private readonly ILogger<TopicsController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public TopicsController(ApplicationDbContext context, ILogger<TopicsController> logger, IMapper mapper,
            UserManager<ApplicationUser> userManager)
            : base(userManager)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        /// <summary>
        /// Zwraca spersonalizowaną propozycję nowego tematu
        /// </summary>
        [HttpGet("ProposeNext")]
        public async Task<TopicViewModel> ProposeNext()
        {
            var user = await GetCurrentUser();

            // Pobranie listy tematów z ostatnich 24h, które nie zostały jeszcze przeczytane przez użytkownika
            var topics =
                (from t in _context.Set<Topic>()
                from s in _context.Set<SeenByUser>().Where(x => x.TopicId != t.Id).DefaultIfEmpty()
                where s == default(SeenByUser) &&
                      t.CreatedAt >= DateTimeOffset.Now.AddHours(-24) &&
                      t.CreatedBy != user.Id
                select t).ToList();

            var allReactionsCount = _context.Reactions
                .Where(x => x.UserId == user.Id)
                .Sum(x => x.PositiveCount);

            // Obliczenie wskaźników dla tagów
            var tagStrength = (_context.Reactions
                .Where(x => x.UserId == user.Id)
                .Select(x => new
                    {Id = x.Id, Keyword = x.Keyword, Strength = x.PositiveCount / (float) allReactionsCount})).ToList();

            // Obliczenie wskaźników dla tematów
            List<(Topic, double)> topicRank = new List<(Topic, double)>();
            double sumOfStrengthValues = 0;
            foreach (var topic in topics)
            {
                double topicStrength = 0;
                foreach (var tag in tagStrength)
                {
                    Regex rgx = new Regex(@"(;|^)" + tag.Keyword + @"(;|$)");
                    // TODO: Contains nie będzie działać w niektórych przypadkach, dorobić potem lepszy regex
                    if (topic.Tags != null && rgx.IsMatch(topic.Tags))
                    {
                        topicStrength += tag.Strength;
                    }
                }
                topicRank.Add((topic, topicStrength));
                sumOfStrengthValues += topicStrength;
            }

            // Normalizacja wskaźników
            //var newTopicRank = topicRank.Select(x => (x.Item1, x.Item2 /= sumOfStrengthValues));

            // Posortuj, weź najlepszy
            var bestTopic = topicRank.OrderByDescending(x => x.Item2).FirstOrDefault();

            return _mapper.Map<TopicViewModel>(bestTopic.Item1);
        }

        /// <summary>
        /// Tworzy czat na podstawie tematu
        /// </summary>
        /// <param name="topicId">Identyfikator wybranego tematu</param>
        /// <response code="200">Zwraca w odpowiedzi unikalny identyfikator utworzonego czatu</response>
        /// <response code="404">Gdy nie znaleziono podanego identyfikatora tematu w bazie</response>
        [HttpPost("ChooseChat")]
        public async Task<ActionResult> CreateChat(int topicId)
        {
            var dbTopic = await _context.Topics.FirstOrDefaultAsync(x => x.Id == topicId);
            if (dbTopic == null)
            {
                return NotFound("Podany temat nie istnieje");
            }

            var user = await GetCurrentUser();

            var addedChat = await _context.Chats.AddAsync(new Chat()
            {
                TopicCreator = dbTopic.CreatedBy,
                TopicAnswerer = user.Id,
                TopicId = dbTopic.Id
            });
            await _context.SaveChangesAsync();

            return Ok(addedChat.Entity.Id);
        }

        /// <summary>
        /// Wysłać w momencie gdy użytkownikowi użytkownik odrzuci zaproponowany temat.
        /// Charakter informacyjny; żeby algorytm miał próbki tematów które nie interesują użytkownika.
        /// </summary>
        /// <param name="topicId">Identyfikator tematu</param>
        [HttpPost("RejectTopicProposal")]
        public async Task<ActionResult> RejectTopicProposal(int topicId)
        {
            var user = GetCurrentUser();
            if (await _context.Topics.AnyAsync(x => x.Id == topicId))
            {
                // TODO: zapisz wzmiankę o zdarzeniu w bazie 

                return Ok();
            }

            return NotFound("Podany temat nie istnieje");
        }

        /// <summary>
        /// Tworzy propozycję nowego tematu
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateTopic")]
        public async Task<ActionResult> CreateTopic([FromBody] TopicCreationViewModel topicCreationViewModel)
        {
            var user = await GetCurrentUser();

            await _context.Topics.AddAsync(new Topic
            {
                Name = topicCreationViewModel.Content,
                CreatedBy = user.Id
            });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}