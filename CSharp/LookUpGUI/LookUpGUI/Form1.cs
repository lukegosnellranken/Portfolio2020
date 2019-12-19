using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookUpGUI
{
    public partial class LookUpGUI : Form
    {

        const int ARRAYSIZE = 5;

        static string[] firstNames = { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri"};
        static string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        static string[] phoneNumbers = { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763"};


        public LookUpGUI()
        {
            InitializeComponent();
        }

        private void LookUpGUI_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxUserInfo.Text = "";
            textBoxSearch.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchNames();
        }


        //////
        private void searchNames()
        {
            string userInput = "";
            userInput = textBoxSearch.Text;

            if (firstNames.Contains(userInput))
            {
                for (int i = 0; i < firstNames.Length; i++)
                {
                    if (firstNames[i] == userInput)
                    {
                        textBoxFirstName.Text = firstNames[i];
                        textBoxLastName.Text = lastNames[i];
                        textBoxPhone.Text = phoneNumbers[i];
                        textBoxUserInfo.Text = "User Found";
                    }
                }
            }
            else if (lastNames.Contains(userInput))
            {
                for (int i = 0; i < lastNames.Length; i++)
                {
                    if (lastNames[i] == userInput)
                    {
                        textBoxFirstName.Text = firstNames[i];
                        textBoxLastName.Text = lastNames[i];
                        textBoxPhone.Text = phoneNumbers[i];
                        textBoxUserInfo.Text = "User Found";
                    }
                }
            }
            else
            {
                displayError();
            }
        }

        private void displayError()
        {
            textBoxFirstName.Text = "error";
            textBoxLastName.Text = "error";
            textBoxPhone.Text = "error";
            textBoxUserInfo.Text = "User Not Found";
        }
    }
}
