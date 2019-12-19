using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobEstimate
{
    public partial class FormJobEstimate : Form
    {
        public FormJobEstimate()
        {
            InitializeComponent();
        }

        public class Job
        {
            //Add instance variables
            private double TRIP_FEE = 35;
            private string _description;
            private float _hoursToComplete;
            private float _hourlyRate;
            private float _totalFee;

            //Constructor
            public Job(String description, float hoursToComplete, float hourlyRate)
            {
                _description = description;
                _hoursToComplete = hoursToComplete;
                _hourlyRate = hourlyRate;
                _totalFee = _hourlyRate * _hoursToComplete + 35;
            }

            //methods to get the data (instance fields)
            public string Description
            {
                get
                {
                    return _description;
                }
            }

            public double HoursToComplete
            {
                get
                {
                    return _hoursToComplete;
                }
            }

            public double HourlyRate
            {
                get
                {
                   return _hourlyRate;
                }
            }

            public double TotalFee
            {
                get
                { 
                return _totalFee;
                }
            }
        }

        Job[] jobs = new Job[20];

        int numJobs = 0;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string descriptionUI = textBoxDescription.Text;
            string hoursToCompleteUI = textBoxHoursToComplete.Text;
            string hourlyRateUI = textBoxHourlyRate.Text;
           // double totalFee = 0;

          //  totalFee = ((Convert.ToDouble(hoursToCompleteUI) * Convert.ToDouble(hourlyRateUI)) + 35);

            jobs[numJobs] = new Job(textBoxDescription.Text, Convert.ToSingle(textBoxHoursToComplete.Text), Convert.ToSingle(textBoxHourlyRate.Text));
            
            labelTotalFeeCV.Text = jobs[numJobs].TotalFee.ToString("C");
            labelDescriptionCV.Text = jobs[numJobs].Description.ToString();
            labelHoursToCompleteCV.Text = jobs[numJobs].HoursToComplete.ToString();
            labelHourlyRateCV.Text = jobs[numJobs].HourlyRate.ToString("C");
            numJobs++;

            labelTotalFeeCV.Visible = true;
            labelDescriptionCV.Visible = true;
            labelHoursToCompleteCV.Visible = true;
            labelHourlyRateCV.Visible = true;
        }
    }
}
