using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class MatchDetail
    {
        public IList<Participant> participants { get; set; }
        public IList<ParticipantIdentity> participantIdentities { get; set; }
        public int gameDuration { get; set; }
    }
}
