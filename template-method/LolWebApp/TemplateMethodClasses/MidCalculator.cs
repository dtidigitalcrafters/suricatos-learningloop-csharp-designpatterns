using LolWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.TemplateMethodClasses
{
    public class MidCalculator : CalculatorTemplate
    {
        public MidCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            var gameTimeInMinutes = (_matchStats.gameDuration / 60);
            var matchStats = _matchStats.stats;

            PropertyCalculator kda = new PropertyCalculator(matchStats.kda);
            setPropertyReferenceValues(kda, 0.5f, 5f, 1f);

            PropertyCalculator damageDealtByMinute = new PropertyCalculator(matchStats.totalDamageDealtToChampions / gameTimeInMinutes);
            setPropertyReferenceValues(damageDealtByMinute, 200f, 1500f, 0.7f);

            PropertyCalculator goldEarned = new PropertyCalculator(matchStats.goldEarned / gameTimeInMinutes);
            setPropertyReferenceValues(goldEarned, 200f, 500f, 0.4f);

            _propertiesList.Add(kda);
            _propertiesList.Add(damageDealtByMinute);
            _propertiesList.Add(goldEarned);
        }
    }
}
