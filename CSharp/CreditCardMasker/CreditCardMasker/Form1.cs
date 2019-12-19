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
using System.Text.RegularExpressions; //this is for Regex

namespace CreditCardMasker
{
    public partial class FormCreditCardMasker : Form
    {
        public FormCreditCardMasker()
        {
            InitializeComponent();
        }

        private void FormCreditCardMasker_Load(object sender, EventArgs e)
        {
            textBoxCCNumber.Text = "";
            labelMasked.Text = "";
            textBoxCCNumber.Focus();
        }

        private void buttonMask_Click(object sender, EventArgs e)
        {
            maskCCNumber();
        }

        public void maskCCNumber() //make methods public
        {
            string userInput = textBoxCCNumber.Text;
            //get rid of dashes and spaces
            if (userInput.Contains(" ") || userInput.Contains("-"))
            {
                userInput.Replace(" ", "");
                userInput.Replace("-", "");
            }
            string firstDigits = userInput.Substring(0, 12);
            string lastDigits = userInput.Substring(userInput.Length - 4, 4);
            var requiredMask = new String('X', firstDigits.Length);
            var maskedString = string.Concat(requiredMask, lastDigits);
            maskedString = Regex.Replace(maskedString, ".{4}", "$0 "); //adds spaces
            labelMasked.Text = maskedString;
        }
    }
}
