using System;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class FormCountVowels : Form
    {
        public FormCountVowels()
        {
            InitializeComponent();
        }

        int totalAs = 0;
        int totalEs = 0;
        int totalIs = 0;
        int totalOs = 0;
        int totalUs = 0;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string thePhrase = textBoxPhrase.Text.ToUpper();

            for(int lcv = 0; lcv < thePhrase.Length; ++lcv)
            {
                switch (thePhrase[lcv].ToString())
                {
                    case "A":
                        ++totalAs;
                        break;
                    case "E":
                        ++totalEs;
                        break;
                    case "I":
                        ++totalIs;
                        break;
                    case "O":
                        ++totalOs;
                        break;
                    case "U":
                        ++totalUs;
                        break;
                    default:
                        break;
                }
            }

            textBoxTotalAs.Text = totalAs.ToString();
            textBoxTotalEs.Text = totalEs.ToString();
            textBoxTotalIs.Text = totalIs.ToString();
            textBoxTotalOs.Text = totalIs.ToString();
            textBoxTotalUs.Text = totalUs.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPhrase.Text = "";
            textBoxTotalAs.Text = "";
            textBoxTotalEs.Text = "";
            textBoxTotalIs.Text = "";
            textBoxTotalOs.Text = "";
            textBoxTotalUs.Text = "";

            //clear all accumulators
            totalAs = 0;
            totalEs = 0;
            totalIs = 0;
            totalOs = 0;
            totalUs = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Program Now?",
                "EXIT PROGRAM?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) ==
                DialogResult.Yes)

            {
                Application.Exit();
            }
        }
    }
}
