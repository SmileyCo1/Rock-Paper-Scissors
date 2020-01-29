using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class RPS : Form
    {
        int UserScore;
        int ComputerScore;

        public RPS()
        {
            InitializeComponent();
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            lblUserOutcome.Text = "Rock";
            Random Ran = new Random();
            int computerChoice = Ran.Next(4);

            if (computerChoice == 1)
            {
                lblComputerOutcome.Text = "Rock";
                lblText.Text = "It's a tie! You both picked rock, try again!";
            }

            else if (computerChoice == 2)
            {
                lblComputerOutcome.Text = "Paper";
                lblText.Text = "You lose! Paper beats rock :(";
                ComputerScore += 1;
                lblComputerScore.Text = ComputerScore.ToString();
            }
            else if (computerChoice == 3)
            {
                lblComputerOutcome.Text = "Scissors";
                lblText.Text = "You win! Rock beats scissors :)";
                UserScore += 1;
                lblUserScore.Text = UserScore.ToString();
            }
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            lblUserOutcome.Text = "Paper";
            Random Ran = new Random();
            int computerChoice = Ran.Next(4);

            if (computerChoice == 1)
            {
                lblComputerOutcome.Text = "Rock";
                lblText.Text = "You win! Paper beats rock :)";
                UserScore += 1;
                lblUserScore.Text = UserScore.ToString();
            }

            else if (computerChoice == 2)
            {
                lblComputerOutcome.Text = "Paper";
                lblText.Text = "It's a tie! You both picked paper, try again!";
            }
            else if (computerChoice == 3)
            {
                lblComputerOutcome.Text = "Scissors";
                lblText.Text = "You lose! Scissors beats paper :(";
                ComputerScore += 1;
                lblComputerScore.Text = ComputerScore.ToString();
            }
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            lblUserOutcome.Text = "Scissors";
            Random Ran = new Random();
            int computerChoice = Ran.Next(4);

            if (computerChoice == 1)
            {
                lblComputerOutcome.Text = "Rock";
                lblText.Text = "You lose! Scissors beats rock :(";
                ComputerScore += 1;
                lblComputerScore.Text = ComputerScore.ToString();
            }

            else if (computerChoice == 2)
            {
                lblComputerOutcome.Text = "Paper";
                lblText.Text = "You win! Scissors beats paper :)";
                UserScore += 1;
                lblUserScore.Text = UserScore.ToString();
            }
            else if (computerChoice == 3)
            {
                lblComputerOutcome.Text = "Scissors";
                lblText.Text = "It's a tie! You both picked scissors, try again!";
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            lblUserScore.Text = "0";
            lblComputerScore.Text = "0";
            lblUserOutcome.Text = "";
            lblComputerOutcome.Text = "";
            lblText.Text = "";
            UserScore = 0;
            ComputerScore = 0;
        }
    }
}
