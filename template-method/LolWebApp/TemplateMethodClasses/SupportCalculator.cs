using LolWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.TemplateMethodClasses
{
    public class SupportCalculator : CalculatorTemplate
    {
        public SupportCalculator(Participant stats) : base(stats) { }

        public override void selectProperties()
        {
            var gameTimeInMinutes = (_matchStats.gameDuration / 60);
            var matchStats = _matchStats.stats;

            PropertyCalculator kda = new PropertyCalculator(matchStats.kda);
            setPropertyReferenceValues(kda, 0.5f, 2f, 0.3f);

            PropertyCalculator visionScorePerMinute = new PropertyCalculator(matchStats.visionScore / gameTimeInMinutes);
            setPropertyReferenceValues(visionScorePerMinute, 1f, 3f, 1f);

            PropertyCalculator totalHeal = new PropertyCalculator(matchStats.totalHeal / gameTimeInMinutes);
            setPropertyReferenceValues(totalHeal, 3f, 6f, 0.3f);

            PropertyCalculator timeCCingOthers = new PropertyCalculator(matchStats.timeCCingOthers / gameTimeInMinutes);
            setPropertyReferenceValues(timeCCingOthers, 0.5f, 2f, 0.5f);

            _propertiesList.Add(kda);
            _propertiesList.Add(visionScorePerMinute);
            _propertiesList.Add(totalHeal);
            _propertiesList.Add(timeCCingOthers);
        }
    }
}
