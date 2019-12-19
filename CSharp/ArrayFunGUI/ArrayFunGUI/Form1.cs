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

namespace ArrayFunGUI
{
    public partial class ArrayFunGUI : Form
    {

        const int ARRAYSIZE = 20;

        static int[] numArray = new int[ARRAYSIZE];
        static int[] origArray = new int[ARRAYSIZE];

        public ArrayFunGUI()
        {
            InitializeComponent();
        }

        private void ArrayFunGUI_Load(object sender, EventArgs e)
        {
            clearListBox();
            generateNewArray();
        }

        private void buttonDisplayArray_Click(object sender, EventArgs e)
        {
            showArrayInOriginalOrder();
        }

        private void buttonLowest_Click(object sender, EventArgs e)
        {
            showArrayInAscendingOrder();
            MessageBox.Show("Smallest array element: " + numArray[0].ToString());
        }

        private void buttonHighest_Click(object sender, EventArgs e)
        {
            showArrayInDescendingOrder();
            MessageBox.Show("Largest array element: " + numArray[0].ToString());
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            sumArrayElements();
        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {
            avgArrayElements();
        }

        private void buttonAscending_Click(object sender, EventArgs e)
        {
            showArrayInAscendingOrder();
        }

        private void buttonDescending_Click(object sender, EventArgs e)
        {
            showArrayInDescendingOrder();
        }

        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            binarySearch();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearListBox();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            help();
        }


        //////
        
        static void generateNewArray()
        {
            Random rand = new Random();

            for (int lcv = 0; lcv < numArray.Length; ++lcv)
            {
                numArray[lcv] = rand.Next(0, 101);
                origArray[lcv] = numArray[lcv];
            }
        }

        private void showArrayInOriginalOrder()
        {
            //ListBox listBoxDisplay = new ListBox();
            //return listBoxDisplay.Text = (listBoxDisplay.Items.Add(numArray)).ToString();

            for (int i = 0; i < numArray.Length; ++i)
            {
                //listBoxDisplay.Items.Add(numArray[i].ToString());
                listBoxDisplay.Items.Add(numArray[i].ToString());
            }
        }

        private void showArrayInAscendingOrder()
        {
            listBoxDisplay.Items.Clear();
            Array.Sort(numArray);
            for (int i = 0; i < numArray.Length; ++i)
            {
                listBoxDisplay.Items.Add(numArray[i].ToString());
            }
        }

        private void showArrayInDescendingOrder()
        {
            listBoxDisplay.Items.Clear();
            Array.Sort(numArray);
            Array.Reverse(numArray);
            for (int i = 0; i < numArray.Length; ++i)
            {
                listBoxDisplay.Items.Add(numArray[i].ToString());
            }
        }

        private void sumArrayElements()
        {
            int sum = 0;
            double avg = 0.0;

            for (int lcv = 0; lcv < ARRAYSIZE; ++lcv)
            {
                sum += numArray[lcv];
            }

            MessageBox.Show("The sum of all numbers in the array is " + sum.ToString());

        }

        private void avgArrayElements()
        {
            int sum = 0;
            double avg = 0.0;

            for (int lcv = 0; lcv < ARRAYSIZE; ++lcv)
            {
                sum += numArray[lcv];
            }

            avg = (double)sum / ARRAYSIZE;

            MessageBox.Show("The average of all numbers in the array is " + avg.ToString("f2"));

        }

        private void binarySearch()
        {
            int userInput = 0;
            showArrayInAscendingOrder();

            if (isNumeric(textBoxBinarySearch.Text))
            {
                userInput = Convert.ToInt32(textBoxBinarySearch.Text);
                if ((userInput < 0) || (userInput > 100))
                {
                    MessageBox.Show("OOR input. Please Re-enter.");
                    textBoxBinarySearch.Text = "";
                    textBoxBinarySearch.Focus();
                }

                //correct input code HERE
                if (numArray.Contains(userInput))
                {
                    MessageBox.Show(userInput.ToString() + " is in the array!");
                }
                else
                {
                    MessageBox.Show(userInput.ToString() + " is NOT the array");
                }

            }
            else
            {
                MessageBox.Show("Non-Numeric input. Please Re-enter.");
                textBoxBinarySearch.Text = "";
                textBoxBinarySearch.Focus();
            }

        }



        //////

        static bool isNumeric(String input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        private void help()
        {
            MessageBox.Show("Click the 'Display Array' button, then try the others!");
        }

        private void clearListBox()
        {
            listBoxDisplay.Items.Clear();
        }

        private void exitApplication()
        {
            if (MessageBox.Show("Do you want to exit?",
                "Exit Program?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

    }
}