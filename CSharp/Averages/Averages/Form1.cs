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

namespace Averages
{
    public partial class Averages : Form
    {

        //const int ARRAYSIZE = 20;

        //static int[] numArray = new int[ARRAYSIZE];
        List<int> numList = new List<int>();

        public Averages()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string userInput = textBoxAdd.Text;
            int value;

            if (userInput.Contains(" "))
            {
                if (!int.TryParse(userInput, out value))
                {
                    MessageBox.Show("Non-Numeric input. Please Re-enter.");
                    textBoxAdd.Text = "";
                    textBoxAdd.Focus();
                }
                else
                {
                    //textBoxDisplay.Text = "Succeeded";
                    foreach (int number in userInput)
                    {
                        numList.Add(value);
                    }
                    
                    outputList();
                    outputAverage();
                }

            }
            else
            {
                if (isNumeric(userInput))
                {
                    numList.Add(Convert.ToInt32(userInput));
                    outputList();
                    outputAverage();
                }
                else
                {
                    MessageBox.Show("Non-Numeric input. Please Re-enter.");
                    textBoxAdd.Text = "";
                    textBoxAdd.Focus();
                }
            }
            
        }

        private void outputList()
        {
            for (int i = 0; i < 400; i++)
            {
                string listString = string.Join(" ", numList.ToArray());
                textBoxDisplay.Text = listString;
            }
        }

        private void outputAverage() {
            textBoxAverage.Text = numList.Average().ToString("F");
        }

        ///////

        static bool isNumeric(String input)
        {
            int test;
            return int.TryParse(input, out test);
        }
    }
}
