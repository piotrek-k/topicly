using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Models.Algorithm;
using Data.Models.Chats;
using Data.Models.Topics;
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
        /// <response code="404">Gdy brakuje tematów do zaproponowania</response> 
        [HttpGet("ProposeNext")]
        public async Task<ActionResult<TopicViewModel>> ProposeNext()
        {
            var userId = GetCurrentUserId();

            // Pobranie listy tematów z ostatnich 24h, które nie zostały jeszcze przeczytane przez użytkownika
            var topics =
                (from t in _context.Set<Topic>().Include(x => x.CreatedBy)
                    from s in _context.Set<SeenByUser>().Where(x => x.TopicId == t.Id).DefaultIfEmpty()
                    where s == null &&
                          t.CreatedAt >= DateTimeOffset.Now.AddHours(-24) &&
                          t.CreatedById != userId
                    select t).ToList();

            var allReactionsCount = _context.Reactions
                .Where(x => x.UserId == userId)
                .Sum(x => x.PositiveCount);

            if (allReactionsCount == 0)
            {
                allReactionsCount = 1;
            }

            // Obliczenie wskaźników dla tagów
            var tagStrength = (_context.Reactions
                .Where(x => x.UserId == userId)
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
                    if (topic.Tags != null && rgx.IsMatch(topic.Tags))
                    {
                        topicStrength += tag.Strength;
                    }
                }

                topicRank.Add((topic, topicStrength));
                sumOfStrengthValues += topicStrength;
            }

            Topic chosenTopic = null;
            if (sumOfStrengthValues > 0)
            {
                // Normalizacja wskaźników (żeby sumowały się do 1)
                var newTopicRank = topicRank.Select(x => (x.Item1, x.Item2 /= sumOfStrengthValues));

                // Potraktuj wskaźniki jak prawdopodobieństwa, wylosuj temat
                Random rand = new Random();
                double previousRates = 0;
                var randNum = rand.NextDouble();

                foreach (var t in newTopicRank)
                {
                    if (randNum >= previousRates && randNum < previousRates + t.Item2)
                    {
                        chosenTopic = t.Item1;
                        break;
                    }

                    previousRates += t.Item2;
                }
            }
            else if (topicRank.Count > 0)
            {
                // zostały same tematy o wskaźnikach 0

                var randNum = new Random().Next(topicRank.Count);
                chosenTopic = topicRank[randNum].Item1;
            }

            if (chosenTopic == null)
            {
                return NotFound("Brak tematów do zaproponowania");
            }

            // Oznacz zwrócony temat jako "zobaczony przez użytkownika". Nie pokazuj go użytkownikowi więcej.
            await _context.SeenByUser.AddAsync(new SeenByUser()
            {
                TopicId = chosenTopic.Id,
                UserId = userId
            });
            await _context.SaveChangesAsync();

            return _mapper.Map<TopicViewModel>(chosenTopic);
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

            var userId = GetCurrentUserId();

            // utworzenie czatu
            var addedChat = await _context.Chats.AddAsync(new Chat()
            {
                TopicCreatorId = dbTopic.CreatedById,
                TopicAnswererId = userId,
                TopicId = dbTopic.Id
            });

            // zwiększenie PositiveCount dla tagów na potrzeby algorytmu proponowania tematu
            if (dbTopic.Tags != null)
            {
                foreach (var tag in dbTopic.Tags.Split(";"))
                {
                    if (tag == "" || tag == null)
                    {
                        continue;
                    }

                    var reaction = _context.Reactions.FirstOrDefault(x => x.UserId == userId && x.Keyword == tag);
                    if (reaction == null)
                    {
                        await _context.Reactions.AddAsync(new UserReaction()
                        {
                            Keyword = tag,
                            NegativeCount = 0,
                            PositiveCount = 1,
                            UserId = userId
                        });
                    }
                    else
                    {
                        reaction.PositiveCount++;
                    }
                }
            }

            await _context.SaveChangesAsync();

            return Ok(new
            {
                chatId = addedChat.Entity.Id,
                otherParticipantId = dbTopic.CreatedById
            });
        }

        /// <summary>
        /// Wysłać w momencie gdy użytkownikowi użytkownik odrzuci zaproponowany temat.
        /// Charakter informacyjny; żeby algorytm miał próbki tematów które nie interesują użytkownika.
        /// </summary>
        /// <param name="topicId">Identyfikator tematu</param>
        [HttpPost("RejectTopicProposal")]
        public async Task<ActionResult> RejectTopicProposal(int topicId)
        {
            var userId = GetCurrentUserId();
            var dbTopic = await _context.Topics.FirstOrDefaultAsync(x => x.Id == topicId);
            if (dbTopic == null)
            {
                return NotFound("Podany temat nie istnieje");
            }

            if (dbTopic.Tags != null)
            {
                foreach (var tag in dbTopic.Tags.Split(";"))
                {
                    if (tag == "")
                    {
                        continue;
                    }

                    var reaction = _context.Reactions.FirstOrDefault(x => x.UserId == userId && x.Keyword == tag);
                    if (reaction == null)
                    {
                        await _context.Reactions.AddAsync(new UserReaction()
                        {
                            Keyword = tag,
                            NegativeCount = 1,
                            PositiveCount = 0,
                            UserId = userId
                        });
                    }
                    else
                    {
                        reaction.NegativeCount++;
                    }
                }

                await _context.SaveChangesAsync();
            }

            return Ok();
        }

        /// <summary>
        /// Tworzy propozycję nowego tematu
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateTopic")]
        public async Task<ActionResult> CreateTopic([FromBody] TopicCreationViewModel topicCreationViewModel)
        {
            var userId = GetCurrentUserId();

            await _context.Topics.AddAsync(new Topic
            {
                Name = topicCreationViewModel.Content,
                CreatedById = userId,
                Tags = topicCreationViewModel.Tags
            });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}