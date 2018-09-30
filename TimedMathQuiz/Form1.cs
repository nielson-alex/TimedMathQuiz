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
        /********************
        * Form1 Variables   *
        ********************/
        Random rdm = new Random();

        int questionNumber = 1;

        int addend1;
        int addend2;

        int minuend1;
        int minuend2;

        int multiplier1;
        int multiplier2;

        int dividend1;
        int dividend2;

        int timeLeft;

        /******************************************
        * Form1 (Basically Page_Load()            *
        ******************************************/
        public Form1()
        {
            InitializeComponent();
            
            setDate();
        }

        // Set the date label to show the current date
        private void setDate()
        {
            lblDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
        }

        // Delete the default value when the user starts entering their own answer
        private void enterAnswer(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;

            if (nud != null)
            {
                int lengthOfAnswer = nud.Value.ToString().Length;
                nud.Select(0, lengthOfAnswer);
            }
        }

        /********************
        * 1. btnStart       *
        ********************/
        private void btnStart_Click(object sender, EventArgs e)
        {
            startQuiz();
            btnStart.Enabled = false;
            hideOtherPanels(questionNumber);
        }

        /***********************************************
        * 1.1 Functions called by btnStart_Click       *
        ***********************************************/
        // Start the timed math quiz
        public void startQuiz()
        {
            // Add values for addition question
            addend1 = rdm.Next(51);
            addend2 = rdm.Next(51);

            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();

            // Add values for subtraction problem
            minuend1 = rdm.Next(51);
            minuend2 = rdm.Next(0, minuend1);

            lblMinusLeft.Text = minuend1.ToString();
            lblMinusRight.Text = minuend2.ToString();

            // Add values for multiplication problem
            multiplier1 = rdm.Next(2, 11);
            multiplier2 = rdm.Next(2, 11);

            lblTimesLeft.Text = multiplier1.ToString();
            lblTimesRight.Text = multiplier2.ToString();

            // Add values for division problem
            dividend2 = rdm.Next(2, 11);
            int tempQuotient = rdm.Next(2, 11);
            dividend1 = dividend2 * tempQuotient;

            lblDivideLeft.Text = dividend1.ToString();
            lblDivideRight.Text = dividend2.ToString();

            // Initialize the timer starting time
            timeLeft = 30;
            lblTimeRemaining.Text = "30 seconds";
            timer.Start();
        }

        // Hide all but the first question
        private void hideOtherPanels(int pnlID)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    if (Convert.ToInt32(c.Name.Replace("pnl", "")) != pnlID)
                    {
                        c.Visible = false;
                    }
                    else
                    {
                        c.Visible = true;
                    }
                }
            }
        }

        // Make timer count down by one second ticks
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimeRemaining.Text = timeLeft + " seconds";
            }
            else
            {
                timer.Stop();
                lblTimeRemaining.Text = "Time's up";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                tbProduct.Text = (addend1 + addend2).ToString();
                tbDifference.Text = (minuend1 - minuend2).ToString();
                tbProduct.Text = (multiplier1 * multiplier2).ToString();
                tbQuotient.Text = (dividend1 / dividend2).ToString();
                btnStart.Enabled = true;
            }
        }

        // Check to see if the answer was correct
        private bool checkAnswer()
        {
            int equationLeftSide = 0;
            int equationRightSide = 0;
            TextBox tbAnswer = new TextBox();
            TextBox[] tbAnswers = { tbSum, tbDifference, tbProduct, tbQuotient };
            bool ifStatement = false;
            switch (questionNumber)
            {
                case 1:
                    equationLeftSide = addend1;
                    equationRightSide = addend2;
                    tbAnswer = tbAnswers[0];
                    if (equationLeftSide + equationRightSide == Convert.ToInt32(tbAnswer.Text.ToString()))
                    {
                        ifStatement = true;
                    }
                    break;
                case 2:
                    equationLeftSide = minuend1;
                    equationRightSide = minuend2;
                    tbAnswer = tbAnswers[1];
                    if (equationLeftSide - equationRightSide == Convert.ToInt32(tbAnswer.Text.ToString()))
                    {
                        ifStatement = true;
                    }
                    break;
                case 3:
                    equationLeftSide = multiplier1;
                    equationRightSide = multiplier2;
                    tbAnswer = tbAnswers[2];
                    if (equationLeftSide * equationRightSide == Convert.ToInt32(tbAnswer.Text.ToString()))
                    {
                        ifStatement = true;
                    }
                    break;
                case 4:
                    equationLeftSide = dividend1;
                    equationRightSide = dividend2;
                    tbAnswer = tbAnswers[3];
                    if (equationLeftSide / equationRightSide == Convert.ToInt32(tbAnswer.Text.ToString()))
                    {
                        ifStatement = true;
                    }
                    
                    break;
                default:
                    break;
            }

            if (ifStatement == true)
            {
                questionNumber++;
                if (questionNumber == 5)
                {
                    timer.Stop();
                    MessageBox.Show("You answered all the questions correctly!", "Good job!");
                    btnStart.Enabled = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel)
                        {
                            c.Visible = true;
                        }
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("That answer is not correct.", "Try again");
                tbAnswer.Focus();
                return false;
            }
        }

        private void enterNext(object sender, EventArgs e)
        {
            if(checkAnswer() && questionNumber != 5)
            {
                hideOtherPanels(questionNumber);
            }             
            else
            {
                questionNumber = 1;
            }
        }
    }
}
