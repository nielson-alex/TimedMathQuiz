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

        int minuend1;
        int minuend2;

        int multiplier1;
        int multiplier2;

        int dividend1;
        int dividend2;

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
            // Add values for addition question
            addend1 = rdm.Next(51);
            addend2 = rdm.Next(51);

            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();

            nudSum.Value = 0;

            // Add values for subtraction problem
            minuend1 = rdm.Next(51);
            minuend2 = rdm.Next(0, minuend1);

            lblMinusLeft.Text = minuend1.ToString();
            lblMinusRight.Text = minuend2.ToString();

            nudDifference.Value = 0;

            // Add values for multiplication problem
            multiplier1 = rdm.Next(2, 11);
            multiplier2 = rdm.Next(2, 11);

            lblTimesLeft.Text = multiplier1.ToString();
            lblTimesRight.Text = multiplier2.ToString();

            nudProduct.Value = 0;
            // Add values for division problem
            dividend1 = rdm.Next(2, 11);
            int tempQuotient = rdm.Next(2, 11);
            dividend2 = dividend1 * tempQuotient;

            lblDivideLeft.Text = dividend1.ToString();
            lblDivideRight.Text = dividend2.ToString();

            nudQuotient.Value = 0;

            // Initialize the timer starting time
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
                lblTimeRemaining.Text = "Time's up";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                nudProduct.Value = addend1 + addend2;
                nudDifference.Value = minuend1 - minuend2;
                nudProduct.Value = multiplier1 * multiplier2;
                nudQuotient.Value = dividend1 / dividend2;
                btnStart.Enabled = true;
            }
        }

        private bool checkAnswer()
        {
            if (addend1 + addend2 == nudSum.Value && 
                minuend1 - minuend2 == nudDifference.Value &&
                multiplier1 * multiplier2 == nudProduct.Value &&
                dividend1 / dividend2 == nudQuotient.Value)
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
