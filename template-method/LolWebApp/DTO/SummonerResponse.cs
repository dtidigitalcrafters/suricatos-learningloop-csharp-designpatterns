using System;
using System.Text.Json.Serialization;

namespace LolWebApp.DTO
{
    public class SummonerResponse
    {
        public String id { get; set; }
        public String accountId { get; set; }
        public String puuid { get; set; }
        public String name { get; set; }
        public int profileIconId { get; set; }
        public Double revisionDate { get; set; }
        public int summonerLevel { get; set; }
    }
}
