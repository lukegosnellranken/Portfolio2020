using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace TinasCustomTees
{
    public partial class TinasCustomTees : Form
    {
        public TinasCustomTees()
        {
            InitializeComponent();
        }

        const double SMALLCOST = 8.00;
        const double MEDIUMCOST = 10.00;
        const double LARGECOST = 12.00;

        int numOrdered = 0;
        double costPerShirt = 0;
        double totalCost = 0.0;

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void radioButtonWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }



        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = SMALLCOST;
            calculateTotals();
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = MEDIUMCOST;
            calculateTotals();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = LARGECOST;
            calculateTotals();
        }


        private void radioButtonOrdered1_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 1;
            calculateTotals();
        }

        private void radioButtonOrdered10_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 10;
            calculateTotals();
        }

        private void radioButtonOrdered100_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 100;
            calculateTotals();
        }


        private void calculateTotals()
        {
            totalCost = numOrdered * costPerShirt;
            textBoxTotalCost.Text = totalCost.ToString("c");
            textBoxDeliveryDate.Text = "T-Shirt Delivery Date: " + monthCalendar1.SelectionStart.AddDays(3).ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
            calculateTotals();
        }

        private void TinasCustomTees_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
            numOrdered = 1;
            costPerShirt = SMALLCOST;
            calculateTotals();

        }
    }
}
