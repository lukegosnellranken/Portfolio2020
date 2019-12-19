using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double MINHOURS = 0.0;
        const double MAXHOURS = 84.0;
        const double MINRATE = 0.0;
        const double MAXRATE = 250.00;
        const double MAXNONOT = 40;
        const double OTRATE = 1.5;
        const string OORINPUT = "Input is out of range or non-numeric";

        double totPayroll = 0.0;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";
            double hoursWorked = 0.0;
            double hourlyRate = 0.0;
            double extraPay = 0.0;
            double grossPay = 0.0;
            bool keepGoing = true;

            if (keepGoing)
            {

                if (isNumeric(textBoxHours.Text) && (Convert.ToDouble(textBoxHours.Text) >= MINHOURS) && (Convert.ToDouble(textBoxHours.Text) <= MAXHOURS))
                {
                    hoursWorked = Convert.ToDouble(textBoxHours.Text);
                }

                else
                {
                    alertMessage(OORINPUT, "inputed is not numeric or out of range");
                    clearHours();
                    return;
                }

                if (isNumeric(textBoxHourlyRate.Text) && (Convert.ToDouble(textBoxHourlyRate.Text) >= MINRATE) && (Convert.ToDouble(textBoxHourlyRate.Text) <= MAXRATE))
                {
                    hourlyRate = Convert.ToDouble(textBoxHourlyRate.Text);
                    if (hoursWorked <= MAXNONOT)
                    {
                        grossPay = (hoursWorked * hourlyRate);
                        textBoxGrossPay.Text = grossPay.ToString("C");
                        totPayroll = (totPayroll + grossPay);
                        textBoxTotalGross.Text = totPayroll.ToString("C");
                    }
                    else
                    {
                        grossPay = (MAXNONOT * hourlyRate);
                        extraPay = ((hoursWorked - MAXNONOT) * hourlyRate * OTRATE);
                        grossPay = (grossPay + extraPay);
                        textBoxGrossPay.Text = grossPay.ToString("C");
                        totPayroll = (totPayroll + grossPay);
                        textBoxTotalGross.Text = totPayroll.ToString("C");
                    }
                    
                }
                else
                {
                    alertMessage(OORINPUT, "inputed is not numeric or out of range");
                    clearHourlyRate();
                    return;
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxHours.Text = "";
            textBoxHourlyRate.Text = "";
            textBoxGrossPay.Text = "";
            textBoxFirstName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit the program now?",
                "EXIT PROGRAM???",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clearHours()
        {
            textBoxHours.Text = "";
            textBoxHours.Focus();
        }

        private void clearHourlyRate()
        {
            textBoxHourlyRate.Text = "";
            textBoxHourlyRate.Focus();
        }

        private bool isNumeric(String input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        private void alertMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            
        }
    }
}
