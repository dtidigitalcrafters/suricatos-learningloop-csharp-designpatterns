using LolWebApp.DTO;
using System;

namespace LolWebApp.TemplateMethodClasses
{
    public sealed class DefaultCalculator : CalculatorTemplate
    {
        public DefaultCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            PropertyCalculator kda = new PropertyCalculator(_matchStats.stats.kda);
            setPropertyReferenceValues(kda, 0.5f, 5f, 1f);

            PropertyCalculator damageDealtByMinute = new PropertyCalculator(_matchStats.stats.totalDamageDealtToChampions/(_matchStats.gameDuration/60));
            setPropertyReferenceValues(damageDealtByMinute, 200f, 1500f, 0.7f);

            float deaths = _matchStats.stats.deaths;
            float damageTakenByDeathValue = (deaths > 0 ? _matchStats.stats.totalDamageTaken / deaths : _matchStats.stats.totalDamageTaken);
            PropertyCalculator damageTakenPerDeath = new PropertyCalculator(damageTakenByDeathValue);
            setPropertyReferenceValues(damageTakenPerDeath, 2000f, 6000f, 0.3f);

            _propertiesList.Add(kda);
            _propertiesList.Add(damageDealtByMinute);
            _propertiesList.Add(damageTakenPerDeath);
        }

    }
}
