using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyXSystem.Entities
{
    internal partial class SingleCalculation
    {
        public int CalculationID { get; set; }

        public int FirstValue { get; set; }

        public string Symbol { get; set; }

        public int SecondValue {get;set;}

        public virtual CalculationHistory CalculationHistory { get; set; }
    }
}
