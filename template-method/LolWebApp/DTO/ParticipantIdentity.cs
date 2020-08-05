using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class ParticipantIdentity
    {
        public class Player
        {
            public string accountId { get; set; }
        }
        public int participantId { get; set; }
        public Player player { get; set; }
    }
}
