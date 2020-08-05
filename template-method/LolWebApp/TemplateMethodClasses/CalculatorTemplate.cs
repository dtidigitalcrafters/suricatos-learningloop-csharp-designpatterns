using LolWebApp.DTO;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text.RegularExpressions;

namespace LolWebApp.TemplateMethodClasses
{
    public abstract class CalculatorTemplate
    {
        public List<PropertyCalculator> _propertiesList;
        public Participant _matchStats;

        public CalculatorTemplate (Participant stats)
        {
            _matchStats = stats;
            _propertiesList = new List<PropertyCalculator>();
        }
        public float templateMethod()
        {
            selectProperties();
            calculateScoreByProperty();

            return calculateAverageScore();
        }
        public abstract void selectProperties();
        public void setPropertyReferenceValues(PropertyCalculator property, float min, float max, float weight)
        {
            property.referenceMinValue = min;
            property.referenceMaxValue = max;
            property.referenceWeight = weight;
        }
        public void calculateScoreByProperty()
        {
            foreach (PropertyCalculator calculator in _propertiesList)
            {
                if (calculator.propertyValue <= calculator.referenceMinValue)
                {
                    calculator.calculatedScore = 0;
                }
                else if (calculator.propertyValue >= calculator.referenceMaxValue)
                {
                    calculator.calculatedScore = 1;
                }
                else
                {
                    float a = 1f / (calculator.referenceMaxValue - calculator.referenceMinValue);
                    float b = calculator.referenceMinValue / (calculator.referenceMinValue - calculator.referenceMaxValue);
                    calculator.calculatedScore = a * calculator.propertyValue + b;
                }
            }
        }

        public float calculateAverageScore()
        {
                float sumScores = 0f;
                float sumWeights = 0f;

                foreach (PropertyCalculator calculator in _propertiesList)
                {
                    sumScores += calculator.calculatedScore * calculator.referenceWeight;
                    sumWeights += calculator.referenceWeight;
                }

                return sumScores / sumWeights;
        }
    }
}
