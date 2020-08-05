using LolWebApp.DTO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LolWebApp.Repository
{
    public class AmIGoodRepository : BaseRepository
    {
        public AmIGoodRepository(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<SummonerResponse> getSummonerResponse(string userId)
        {
            var responseStream = HttpGet("summoner/v4/summoners/by-name/" + userId + "?");
            return await JsonSerializer.DeserializeAsync<SummonerResponse>(responseStream.Result);
        }

        public async Task<MatchResponse> getMatchesResponse(string accountId)
        {
            var responseStream = HttpGet("match/v4/matchlists/by-account/" + accountId + "?queue=400&endIndex=10");
            return await JsonSerializer.DeserializeAsync<MatchResponse>(responseStream.Result);
        }

        public async Task<MatchDetail> getMatchInformation(int gameId)
        {
            var responseStream = HttpGet("match/v4/matches/" + gameId + "?");
            return await JsonSerializer.DeserializeAsync<MatchDetail>(responseStream.Result);
        }
    }
}
