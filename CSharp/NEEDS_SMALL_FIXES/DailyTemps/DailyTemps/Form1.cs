using System;
using System.Windows.Forms;
using System.Threading.Tasks;

/*
 *  Write an application named DailyTemps that 
 *  continuously prompts a user for a series of 
 *  daily high temperatures until the user enters 
 *  a sentinel value of -999.
 *  
 *  Valid temperatures range from -50 through 130
 *  Fahrenheit. If a user enters a valid temperature,
 *  add it to a total. If a user enters an invalid
 *  temperature, display an error message.
 *  
 *  Before the program ends, display the number of 
 *  temperatures entered and the average temperature.
 */

namespace DailyTemps
{
    public partial class FormDailyTemps : Form
    {
        public FormDailyTemps()
        {
            InitializeComponent();
        }

        const int MINTEMP = -20;
        const int MAXTEMP = 130;
        const int ENDTEMP = -999;
        const string TEMPOOR = "Temp must be between -20 and 130";

        int totDegrees = 0;
        int highTemp = -21;
        int numTemps = 0;

        //*********************************

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int temp = 0;   //inputed temp
            double avgTemp = 0.0;   //avg of all inputed temps
            bool keepGoing = true;   //program continue variable

            if (keepGoing)
            {
                if (isNumeric(textBoxTemp.Text))   //if input is numeric, convert it!
                {
                    temp = Convert.ToInt32(textBoxTemp.Text);

                    if (temp == ENDTEMP)  //checking for end of program temp
                    {
                        avgTemp = calculateAvgTemp(totDegrees, numTemps);
                        textBoxAvgTemp.Text = avgTemp.ToString("f2");
                        timeToExitProgram();
                        return;
                    }

                    if ((temp < MINTEMP) || (temp > MAXTEMP))   //check for out of range temp
                    {
                        alertMessage(TEMPOOR, "Out of Range Temp Input");
                        clearTempTextBox();
                    }

                    else
                    {
                        ++numTemps;   //increment total by 1
                        totDegrees += temp;   //add degrees for current temp to accumulator
                        if (temp > highTemp)   // if true, new high temp/replace current
                        {
                            highTemp = temp;
                            textBoxHighTemp.Text = highTemp.ToString();
                        }
                    }
                }

                else   //inputed temp was NOT numeric
                {
                    alertMessage(TEMPOOR, "inputed temp not numeric");
                    clearTempTextBox();
                    return;
                }
            }
        }

        //*********************************

        public double calculateAvgTemp(int totDegrees,
                                       int numTemps)
        {
            return ((double) (totDegrees) / numTemps);
        }

        //*********************************

        private void clearTempTextBox()
        {
            textBoxTemp.Text = "";
            textBoxAvgTemp.Focus();
        }

        //*********************************

        private bool isNumeric(String input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        //*********************************

        private void alertMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            textBoxTemp.Text = "";
        }

        //*********************************

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTemp.Text = "";
            textBoxHighTemp.Text = "";
            textBoxAvgTemp.Text = "";
            textBoxTemp.Focus();
        }

        //*********************************

        private void buttonExit_Click(object sender, EventArgs e)
        {
            timeToExitProgram();
        }

        //*********************************

        private void timeToExitProgram()
        {
            if (MessageBox.Show("Exit program now?",
                                "Exit Program?!?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) ==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
