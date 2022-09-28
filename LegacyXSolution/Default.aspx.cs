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
            // History.visible = !History.visible;

            // I choose this way of coding it because it is clean and does the required work efficiently
        }

        protected void SaveHistory_Click(object sender, EventArgs e)
        {
            /*
                query for download path;
                create text file with CalcutionHistory printed in order
                modal popup with question "Would you like to start new Calculation Group?"
                    if yes
                        create text or excel file (check with client for prefference) 
                        use download path to download file
                        call clearCalculationHistory()
                    if no
                        close modal
            */

            // I plan to use a modal popup so that the user has a chance to make sure everything is as they want it and to make sure
            //          the button click was intentional
            // The call to the clear history function was so that I didn't have to write the same code twice
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

            // Once again, the modal is there in case of a miss click and just to double check with the client. I would Bold the 
            //          part of the message that says "delete" so that they notice it's not to save the data
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

            // I plan to use a Object Data Source in conjunction with a Database to hold the data temperarly
            // I don't know if this is the most effiecnt solution but it is with the knowledge I currently posess 
        }
    }
}