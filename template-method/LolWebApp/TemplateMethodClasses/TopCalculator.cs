using LolWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.TemplateMethodClasses
{
    public class TopCalculator : CalculatorTemplate
    {
        public TopCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            var gameTimeInMinutes = (_matchStats.gameDuration / 60);
            var matchStats = _matchStats.stats;

            PropertyCalculator kda = new PropertyCalculator(matchStats.kda);
            setPropertyReferenceValues(kda, 0.5f, 3f, 0.6f);

            float deaths = _matchStats.stats.deaths;
            float damageTakenByDeathValue = (deaths > 0 ? _matchStats.stats.totalDamageTaken / deaths : _matchStats.stats.totalDamageTaken);
            PropertyCalculator damageTakenPerDeath = new PropertyCalculator(damageTakenByDeathValue);
            setPropertyReferenceValues(damageTakenPerDeath, 2000f, 6000f, 0.5f);

            PropertyCalculator damageSelfMitigated = new PropertyCalculator(matchStats.damageSelfMitigated / gameTimeInMinutes);
            setPropertyReferenceValues(damageSelfMitigated, 700f, 2000f, 0.9f);

            _propertiesList.Add(kda);
            _propertiesList.Add(damageTakenPerDeath);
            _propertiesList.Add(damageSelfMitigated);
        }
    }
}
