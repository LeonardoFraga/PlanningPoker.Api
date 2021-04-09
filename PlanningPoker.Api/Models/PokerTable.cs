namespace PlanningPoker.Api.Models
{
    public class PokerTable
    {
        public PokerTable(string pokerTableId, string[] cards)
        {
            PokerTableId = pokerTableId;
            Cards = cards;
        }

        public string PokerTableId { get; set; }
        public string[] Cards { get; set; }
    }
}
