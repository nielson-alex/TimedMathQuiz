using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {
        Random rdm = new Random();

        int addend1;
        int addend2;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        /********************
        * 1. btnStart       *
        ********************/
        private void btnStart_Click(object sender, EventArgs e)
        {
            startQuiz();
            btnStart.Enabled = false;
        }

        // Start the timed math quiz
        public void startQuiz()
        {
            addend1 = rdm.Next(51);
            addend2 = rdm.Next(51);

            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();

            nudSum.Value = 0;

            timeLeft = 30;
            lblTimeRemaining.Text = "30 seconds";
            timer.Start();
        }

        // Make timer count down by one second ticks
        private void timer_Tick(object sender, EventArgs e)
        {
            if (checkAnswer())
            {
                timer.Stop();
                MessageBox.Show("You got all the answers right!", "Contratulations!");
                btnStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimeRemaining.Text = timeLeft + " seconds";
            }
            else
            {
                timer.Stop();
                lblTimeRemaining.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry.");
                nudSum.Value = addend1 + addend2;
                btnStart.Enabled = true;
            }
        }

        private bool checkAnswer()
        {
            if (addend1 + addend2 == nudSum.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void enterAnswer(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;

            if (nud != null)
            {
                int lengthOfAnswer = nud.Value.ToString().Length;
                nud.Select(0, lengthOfAnswer);
            }
        }
    }
}
