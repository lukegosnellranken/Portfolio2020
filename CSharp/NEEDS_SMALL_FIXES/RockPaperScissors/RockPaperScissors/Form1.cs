using System;
using System.Windows.Forms;

/*
 *      In the game Rock Paper Scissors, two players 
 *      simultaneously choose one of three options: 
 *      rock, paper, or scissors.
 *      
 *      If both players choose the same option, then
 *      the result is a tie.
 *      
 *      However, if they choose differently, the winner
 *      is determined as follows:
 *      
 *      •	Rock beats scissors, because a rock can break 
 *          a pair of scissors. 
 *          
 *      •	Scissors beats paper, because scissors can cut 
 *          paper. 
 *          
 *      •	Paper beats rock, because a piece of paper can 
 *          cover a rock. 
 *          
 *      Create a game in which the computer randomly chooses 
 *      rock, paper, or scissors. Let the user enter a character, 
 *      r, p, or s, each representing one of the three choices. 
 *      
 *      Then, determine the winner. Save the application as 
 *      RockPaperScissors.
 */

namespace RockPaperScissors
{
    public partial class FormRockPapeerSccissors : Form
    {
        public FormRockPapeerSccissors()
        {
            InitializeComponent();
        }

        string userChoiceStr = "";
        int userChoice = 0;
        string computerChoiceStr = "";
        int computerChoice = 0;
        int computerWins = 0;
        int userWins = 0;
        int ties = 0;

        private void FormRockPapeerSccissors_Load(object sender, EventArgs e)
        {
            gameInstructions();
        }

        private void gameInstructions()
        {
            string outputStr = "";
            outputStr += "Welcome to Rock Paper Scissors!";

            MessageBox.Show(outputStr,
                            "Rock, Paper, Scissors Rules, etc.",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllUpperTextBoxes();
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            clearAllUpperTextBoxes();
            clearAllLowerTextBoxes();
            clearAllCounters();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit program?",
                                "EXIT PROGRAM???",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) ==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clearAllUpperTextBoxes()
        {
            textBoxUserChoice.Text = "";
            textBoxComputerChoice.Text = "";
            textBoxWinner.Text = "";

        }

        private void clearAllLowerTextBoxes()
        {
            textBoxUserWins.Text = "";
            textBoxComputerWIns.Text = "";
            textBoxTies.Text = "";

        }

        private void clearAllCounters()
        {
            userWins = 0;
            computerWins = 0;
            ties = 0;

        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            userChoiceStr = "Rock";
            userChoice = 1;
            makeComputerChoice();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            userChoiceStr = "Paper";
            userChoice = 1;
            makeComputerChoice();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            userChoiceStr = "Scissors";
            userChoice = 3;
            makeComputerChoice();
        }


        private void makeComputerChoice()
        {
            Random rnd = new Random();
            computerChoice = rnd.Next(1, 4);

            textBoxUserChoice.Text = userChoiceStr;

            switch (computerChoice)
            {
                case 1:
                    computerChoiceStr = "Rock";
                    break;
                case 2:
                    computerChoiceStr = "Paper";
                    break;
                case 3:
                    computerChoiceStr = "Scissors";
                    break;
                default:
                    computerChoiceStr = "Rock";
                    break;
            }

            textBoxComputerChoice.Text = computerChoiceStr;
            textBoxUserChoice.Text = userChoiceStr;

            determineWinner();

        }

        private void determineWinner()
        {
            string winner = "";

            if (userChoice == computerChoice)
            {
                winner = "Tie Game";
                ++ties;
            }
            else if ((userChoice == 1) && (computerChoice == 3) ||
                    (userChoice == 2) && (computerChoice == 1) ||
                    (userChoice == 3) && (computerChoice == 2))
            {
                winner = "User";
                ++userWins;
            }
            else if ((computerChoice == 1) && (userChoice ==3) ||
                    (computerChoice == 2) && (userChoice == 1) ||
                    (computerChoice == 3) && (userChoice == 2))
            {
                winner = "Computer";
                ++computerWins;
            }

            textBoxWinner.Text = winner;

            textBoxUserWins.Text = userWins.ToString();
            textBoxComputerWIns.Text = computerWins.ToString();
            textBoxTies.Text = ties.ToString();

        }

        
    }
}
