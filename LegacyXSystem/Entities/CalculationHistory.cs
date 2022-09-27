using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyXSystem.Entities
{
    internal partial class CalculationHistory
    {
        public int GroupCalculationID { get; set; }

        public virtual ICollection<SingleCalculation> SingleCalculations { get; set; }
    }
}
