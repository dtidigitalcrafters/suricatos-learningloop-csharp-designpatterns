using LolWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.TemplateMethodClasses
{
    public class JungleCalculator : CalculatorTemplate
    {
        public JungleCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            var gameTimeInMinutes = (_matchStats.gameDuration / 60);
            var matchStats = _matchStats.stats;

            PropertyCalculator kda = new PropertyCalculator(matchStats.kda);
            setPropertyReferenceValues(kda, 0.5f, 3f, 0.5f);

            PropertyCalculator visionScorePerMinute = new PropertyCalculator(matchStats.visionScore / gameTimeInMinutes);
            setPropertyReferenceValues(visionScorePerMinute, 0.5f, 2f, 0.7f);

            PropertyCalculator neutralMinionsKilledByMinute = new PropertyCalculator(matchStats.neutralMinionsKilled / gameTimeInMinutes);
            setPropertyReferenceValues(neutralMinionsKilledByMinute, 3f, 6f, 1f);

            _propertiesList.Add(kda);
            _propertiesList.Add(visionScorePerMinute);
            _propertiesList.Add(neutralMinionsKilledByMinute);
        }
    }
}
