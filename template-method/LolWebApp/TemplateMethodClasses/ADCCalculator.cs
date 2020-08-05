using LolWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.TemplateMethodClasses
{
    public class ADCCalculator : CalculatorTemplate
    {
        public ADCCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            var gameTimeInMinutes = (_matchStats.gameDuration / 60);
            var matchStats = _matchStats.stats;

            PropertyCalculator kda = new PropertyCalculator(matchStats.kda);
            setPropertyReferenceValues(kda, 0.5f, 5f, 0.7f);

            PropertyCalculator damageDealtToObjectivesByMinute = new PropertyCalculator(matchStats.damageDealtToObjectives/gameTimeInMinutes);
            setPropertyReferenceValues(damageDealtToObjectivesByMinute, 200f, 800f, 0.9f);

            PropertyCalculator minionsKilledByMinute = new PropertyCalculator(matchStats.totalMinionsKilled/gameTimeInMinutes);
            setPropertyReferenceValues(minionsKilledByMinute, 5f, 10f, 1f);

            _propertiesList.Add(kda);
            _propertiesList.Add(damageDealtToObjectivesByMinute);
            _propertiesList.Add(minionsKilledByMinute);
        }
    }
}
