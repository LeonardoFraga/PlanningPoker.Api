using Microsoft.AspNetCore.Mvc;
using PlanningPoker.Api.Models;

namespace PlanningPoker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokerTableController : Controller
    {
        [HttpGet]
        public IActionResult GetPokerTableCards(string pokerTableId)
        {
            // Get values from redis

            // var cards = string strResult = RedisConnector.Get<string>(pokerTableId);
            var cards = "1,2,3,4,5,6,7";

            return Ok(cards);
        }

        [HttpPost]
        public IActionResult CreatePokerTable([FromBody] PokerTable pokerTable)
        {
            // Add values on redis
            //RedisConnector.Set(pokerTable.PokerTableId, pokerTable.Cards);

            return Ok(new { Message = "Voted with success"});
        }
    }
}
