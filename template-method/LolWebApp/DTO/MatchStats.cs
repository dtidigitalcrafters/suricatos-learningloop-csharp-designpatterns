using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class MatchStats
    {
        public bool win { get; set; }
        public float kills { get; set; }
        public float deaths { get; set; }
        public float assists { get; set; }
        public float kda => (deaths > 0 ? (kills + assists) / deaths : (kills + assists));
        public int totalDamageDealtToChampions { get; set; }
        public int totalHeal { get; set; }
        public int damageSelfMitigated { get; set; }
        public int damageDealtToObjectives { get; set; }
        public int visionScore { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalDamageDealt { get; set; }
        public int goldEarned { get; set; }
        public int totalMinionsKilled { get; set; }
        public int neutralMinionsKilled { get; set; }
        public int totalTimeCrowdControlDealt { get; set; }
        public int wardsPlaced { get; set; }
        public int wardsKilled { get; set; }
        public int timeCCingOthers { get; set; }
    }
}
