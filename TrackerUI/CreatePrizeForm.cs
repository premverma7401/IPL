using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizerBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    pNumberInput.Text,
                    pNameInput.Text,
                    pAmountInput.Text,
                    pPercentageInput.Text);
                // Here sending model data to db.
                GlobalConfig.Connections.CreatePrize(model);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeValidNumber = int.TryParse(pNumberInput.Text, out placeNumber);
            if (!placeValidNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (pNameInput.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeValidAmount = decimal.TryParse(pAmountInput.Text, out prizeAmount);
            bool prizeValidPercentage = double.TryParse(pPercentageInput.Text, out prizePercentage);

            if (!prizeValidAmount || !prizeValidPercentage)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
        private void ClearForm()
        {
            pNumberInput.Text = "";
            pNameInput.Text = "";
            pAmountInput.Text = "0";
            pPercentageInput.Text = "0";
        }
    }
}
