using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LegacyXSolution
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowHistory_Click(object sender, EventArgs e)
        {
            /* 
             * if (showHistory = clicked)
                history.visible = !history.visible;
            */
        }

        protected void SaveHistory_Click(object sender, EventArgs e)
        {
            /*
                if (saveHistory = clicked)
                {
                    // query for download path;
                    // create text file with CalcutionHistory printed in order
                    // modal popup with question "Would you like to start new Calculation Group?"
                    //    if yes
                    //      call clearCalculationHistory()
                    //    if no
                    //      close modal
                }
            */
        }

        protected void ClearHistory_Click(object sender, EventArgs e)
        {
            /*
                if (clearHistory = clicked)
                {
                    // modal popup with question "Are you sure you want to delete current History?"
                    if (modalButton = confirm)
                    {
                        create new CalculationHistory;
                        currentCalculationHistory = newCalculationHistory;
                    }
                    else
                    {
                        close modal
                  }
                }
            */
        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            /*
                if(validationErrors = null)
                {
                    create new SingleCalulation;
                    SingleCalculation.values = current.values;
                    CalculationHistory.add(SingleCalculation);

                    // return inputBox1 to default;
                    // return inputBox2 to default;
                    // do not change symbol dropdown
                } else
                {
                    display errors
                }
            */
        }
    }
}