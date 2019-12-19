using System;
using System.Windows.Forms;

/*
 *      Write a program named MoveEstimatorGUI that 
 *      prompts a user for the number of hours for a 
 *      moving job and the number of miles involved 
 *      in the move.
 *      
 *      After the user clicks a Button, display the 
 *      moving fee which includes a base rate of $200 
 *      plus $150 per hour and $2 per mile.
 */

namespace MoveEstimatorGUI
{
    public partial class FormMoveEsimatorGUI : Form
    {
        public FormMoveEsimatorGUI()
        {
            InitializeComponent();
        }


        //*******************************************
        const double MOVEBASERATE = 200.00;
        const double MOVEPERHOURRATE = 150.00;
        const double MOVEPERMILERATE = 2.00;
        const string ILLEGALINPUT = "ILLEGAL INPUT";
        const string NNOROORINPUT = "Non-numeric or out of range input";


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            double hours = 0.0;
            double miles = 0.0;
            double bill = 0.0;

            keepGoing = isNumeric(textBoxHours.Text);

            if (keepGoing)
            {
                hours = Convert.ToDouble(textBoxHours.Text);
                keepGoing = isNumeric(textBoxMiles.Text);
            }

            else
            {
                alertMessage(NNOROORINPUT,
                             ILLEGALINPUT);
                textBoxHours.Text = "";
                textBoxHours.Focus();
                return;
            }

            if (keepGoing)
            {
                miles = Convert.ToDouble(textBoxMiles.Text);
                bill = calculateBill(hours, miles);
                textBoxBill.Text = bill.ToString("C");
            }

            else
            {
                alertMessage(NNOROORINPUT,
                             ILLEGALINPUT);
                textBoxMiles.Text = "";
                textBoxMiles.Focus();
            }
        }

        //*******************************************

        private bool isNumeric(String input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        //*******************************************

        private void alertMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        //*******************************************

        private double calculateBill(double h, double m)
        {
             return (MOVEBASERATE +
                    (h * MOVEPERHOURRATE) +
                    (m * MOVEPERMILERATE));

        }

        //*******************************************

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxHours.Text = "";
            textBoxMiles.Text = "";
            textBoxBill.Text = "";
            textBoxHours.Focus();
        }

        //*******************************************

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("exit the program?",
                                "EXIT PROGRAM???",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) ==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //*******************************************
    }
}
