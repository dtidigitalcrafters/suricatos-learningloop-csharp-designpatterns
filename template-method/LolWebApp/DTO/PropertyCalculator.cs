using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolWebApp.DTO
{
    public class PropertyCalculator
    {
        public PropertyCalculator (float value)
        {
            propertyValue = value;
        }
        public float propertyValue { get; set; }
        public float referenceMinValue { get; set; }
        public float referenceMaxValue { get; set; }
        public float calculatedScore { get; set; }
        public float referenceWeight { get; set; }
    }
}
