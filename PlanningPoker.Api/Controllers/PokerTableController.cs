using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using PlanningPoker.Api.Dtos;
using PlanningPoker.Api.Models;
using System;

namespace PlanningPoker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokerTableController : Controller
    {

        private readonly IDistributedCache _distributedCache;

        public PokerTableController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        [HttpGet]
        public IActionResult GetPokerTableCards(string pokerTableId)
        {
            var cards = _distributedCache.GetString(pokerTableId);
            var pokerTable = new PokerTable(pokerTableId, cards.Split(','));

            return new JsonResult(pokerTable);
        }

        [HttpPost]
        public IActionResult CreatePokerTable([FromBody] PokerTableDto pokerTable)
        {
            // Add param validator

            _distributedCache.SetString(pokerTable.PokerTableId, pokerTable.Cards, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1)
            });

            return new JsonResult("Poker Table created with success.");
        }
    }
}
