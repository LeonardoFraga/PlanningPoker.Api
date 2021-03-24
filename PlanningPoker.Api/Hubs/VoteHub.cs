using Microsoft.AspNetCore.SignalR;
using PlanningPoker.Api.Models;
using System.Threading.Tasks;

namespace PlanningPoker.Api.Hubs
{
    public class VoteHub : Hub
    {
        public Task JoinGroup(string groupName)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public Task SendGoupMessage(Vote vote)
        {
            return Clients.Group(vote.GroupName).SendAsync("sendMessageToAGroup", vote.Value);
        }
    }
}
