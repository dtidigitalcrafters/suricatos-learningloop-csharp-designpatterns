using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class MatchResume
    {
        public string platformId { get; set; }
        public int gameId { get; set; }
        public int champion { get; set; }
        public int queue { get; set; }
        public int season { get; set; }
        public double timestamp { get; set; }
        public string role { get; set; }
        public string lane { get; set; }
    }
}
