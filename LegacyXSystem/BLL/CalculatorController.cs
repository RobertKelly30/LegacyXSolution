using LegacyXSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyXSystem.BLL
{
    [DataObject]
    class CalculatorController
    {
        public List<SingleCalculation> ListSingleCalculations()
        {
            // using context for database access

            // query database for all current SingleCalculations
            // return data as List
            return null;
        }

        public void AddSingleCalculation(SingleCalculation item)
        {
            // using context for database access

            // Add Single Calculation to database
            // Save Changes
        }

        public void DeleteSingleCalculations()
        {
            // using context for database access

            // context.SingleCalculation(sql table).Delete; 
            //      To my knowledge, this would delete everything on the table leaving us a fresh start
            // Save Changes
        }
    }
}
