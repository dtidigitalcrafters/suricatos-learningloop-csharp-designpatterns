using LolWebApp.DTO;
using LolWebApp.Repository;
using LolWebApp.TemplateMethodClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LolWebApp.Service
{
    public class AmIGoodService
    {
        private AmIGoodRepository _repository;
        private IHttpClientFactory _clientFactory;

        public AmIGoodService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public Participant getMyStats(string accountId, MatchDetail match)
        {
            int _participantId = 0;

            foreach (ParticipantIdentity participant in match.participantIdentities)
            {
                if (participant.player.accountId.Equals(accountId))
                {
                    _participantId = participant.participantId;
                    break;
                }
            }

            foreach (Participant participant in match.participants)
            {
                if (participant.participantId.Equals(_participantId))
                {
                    participant.gameDuration = match.gameDuration;
                    return participant;
                }
            }

            return null;
        }
        public List<Participant> getListMatchStats(string accountId, List<MatchDetail> listMatchDetail)
        {
            List<Participant> listMatchStats = new List<Participant>();
            foreach (MatchDetail matchDetail in listMatchDetail)
            {
                listMatchStats.Add(getMyStats(accountId, matchDetail));
            }

            return listMatchStats;
        }

        public float getScoreFromList (string accountId, List<MatchDetail> listMatchDetail)
        {
            List<Participant> listMatchStats = getListMatchStats(accountId, listMatchDetail);
            List<float> scores = new List<float>();

            foreach(Participant participant in listMatchStats)
            {
                if (participant == null) break;
                CalculatorTemplate calculator;
                var lane = participant.timeline.lane;
                switch (lane)
                {
                    case "JUNGLE": 
                        calculator = new JungleCalculator(participant);
                        break;
                    case "TOP":
                        calculator = new TopCalculator(participant);
                        break;
                    case "MIDDLE":
                        calculator = new MidCalculator(participant);
                        break;
                    case "BOTTOM":
                        var role = participant.timeline.role;
                        if (role.Equals("DUO_CARRY"))
                        {
                            calculator = new ADCCalculator(participant);
                        } else if (role.Equals("DUO_SUPPORT"))
                        {
                            calculator = new SupportCalculator(participant);
                        } else
                        {
                            calculator = new DefaultCalculator(participant);
                        }
                        break;
                    default:
                        calculator = new DefaultCalculator(participant);
                        break;
                }

                scores.Add(calculator.templateMethod());
            }

            if (scores.Count == 0) return 0f;
            return scores.Average();

        }

        public async Task<float> getAverageScore(string userId)
        {
            _repository = new AmIGoodRepository(_clientFactory);
            SummonerResponse summonerData = await _repository.getSummonerResponse(userId);
            MatchResponse matchResponse = await _repository.getMatchesResponse(summonerData.accountId);
            List<MatchDetail> listMatchDetail = new List<MatchDetail>();

            if (matchResponse.matches == null) return 0f;
            foreach (MatchResume resume in matchResponse.matches)
            {
                try
                {
                    MatchDetail match = await _repository.getMatchInformation(resume.gameId);
                    listMatchDetail.Add(match);
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Thread.Sleep(100);
            }

            return getScoreFromList(summonerData.accountId, listMatchDetail);
        }
    }
}
