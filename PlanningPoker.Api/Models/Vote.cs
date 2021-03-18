using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanningPoker.Api.Models
{
    public class Vote
    {
        public string Value { get; set; }

        public string GroupName { get; set; }

        public string Votter { get; set; }
    }
}
