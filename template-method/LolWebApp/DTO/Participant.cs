using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class Participant
    {
        public int participantId { get; set; }
        public MatchStats stats { get; set; }
        public Timeline timeline { get; set; }
        public int gameDuration { get; set; }
    }
}
